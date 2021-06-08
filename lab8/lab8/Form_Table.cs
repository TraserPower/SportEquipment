using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace lab8
{
    public partial class Form_Table : Form
    {
        public Table Table { get; set; }
        public Role Role { get; set; }
        Sport_Equipment db;

        public Form_Table(Table table, Role role)
        {
            InitializeComponent();

            Table = table;
            Role = role;

            db = new Sport_Equipment();
            
            createElements();
            fillColumns();
            fill_cb_Column();
        }

         ////////////////////////////////
        //////// ЗАПОЛНЕНИЕ ДГВ ////////

        #region ЗАПОЛНЕНИЕ ДГВ
        private void fillColumns()
        {
            switch(Table)
            {
                case Table.Firm:
                    fillColumnsFirm();
                    break;

                case Table.SportEquipment:
                    fillColumnsSportEquipment();
                    break;

                case Table.Sportsman:
                    fillColumnsSportsman();
                    break;

                case Table.OwnEquipment:
                    fillColumnOwnEquipment();
                    break;

                case Table.Register:
                    fillColumnRegister();
                    break;
            }

            fillDgv();
        }

        private void fillColumnsFirm()
        {
            db.Firms.Load();

            dgv.ColumnCount = 3;

            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 235;
            dgv.Columns[1].HeaderText = "Название";

            dgv.Columns[2].Width = 229;
            dgv.Columns[2].HeaderText = "Количество сотрудников";
        }

        private void fillColumnsSportEquipment()
        {
            db.SportEquipments.Load();

            dgv.ColumnCount = 4;

            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 155;
            dgv.Columns[1].HeaderText = "Название";

            dgv.Columns[2].Width = 154;
            dgv.Columns[2].HeaderText = "Цена";

            dgv.Columns[3].Width = 153;
            dgv.Columns[3].HeaderText = "Фирма";
        }

        private void fillColumnsSportsman()
        {
            db.Sportsmen.Load();

            dgv.ColumnCount = 3;

            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 265;
            dgv.Columns[1].HeaderText = "Имя";

            dgv.Columns[2].Width = 199;
            dgv.Columns[2].HeaderText = "Возраст";
        }

        private void fillColumnOwnEquipment()
        {
            db.SportEquipments.Load();

            dgv.ColumnCount = 4;

            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 180;
            dgv.Columns[1].HeaderText = "Спортсмен";

            dgv.Columns[2].Width = 179;
            dgv.Columns[2].HeaderText = "Спорт инвентарь";

            dgv.Columns[3].Width = 103;
            dgv.Columns[3].HeaderText = "Количество";
        }

        private void fillColumnRegister()
        {
            db.Registers.Load();

            dgv.ColumnCount = 5;

            dgv.Columns[0].Visible = false;

            dgv.Columns[1].Width = 98;
            dgv.Columns[1].HeaderText = "Логин";

            dgv.Columns[2].Width = 184;
            dgv.Columns[2].HeaderText = "Хэш пароля";

            dgv.Columns[3].Width = 110;
            dgv.Columns[3].HeaderText = "Соль";

            dgv.Columns[4].Width = 70;
            dgv.Columns[4].HeaderText = "Админ";
        }


        private void fillDgv()
        {
            switch(Table)
            {
                case Table.Firm:

                    var fquery = from n in db.Firms
                                 select new
                                 {
                                     n.ID,
                                     n.Name,
                                     n.EmployeeCount
                                 };

                    foreach(var g in fquery.ToArray())
                    {
                        dgv.Rows.Add(new object[] { g.ID, g.Name, g.EmployeeCount });
                    }

                    break;

                case Table.SportEquipment:
                    
                    var equery = from s in db.SportEquipments
                                select new
                                {
                                    s.ID,
                                    s.Name,
                                    s.Price,
                                    Firm = s.Firm.Name
                                };

                    foreach(var g in equery.ToArray())
                    {
                        dgv.Rows.Add(new object[] { g.ID, g.Name, g.Price.ToString("F"), g.Firm });
                    }

                    break;

                case Table.Sportsman:

                    var squery = from n in db.Sportsmen
                                 select new
                                 {
                                     n.ID,
                                     n.Name,
                                     n.Age
                                 };

                    foreach(var g in squery.ToArray())
                    {
                        dgv.Rows.Add(new object[] { g.ID, g.Name, g.Age });
                    }

                    break;

                case Table.OwnEquipment:

                    var oquery = from o in db.OwnEquipments
                                 select new
                                 {
                                     o.ID,
                                     sName = o.Sportsman.Name,
                                     eName = o.SportEquipment.Name,
                                     o.Count
                                 };

                    foreach (var g in oquery.ToArray())
                    {
                        dgv.Rows.Add(new object[] { g.ID, g.sName, g.eName, g.Count });
                    }

                    break;

                case Table.Register:

                    var rquery = from n in db.Registers
                                 select new
                                 {
                                     n.ID,
                                     n.Login,
                                     n.PasswordHash,
                                     n.Salt,
                                     n.isAdmin
                                 };

                    foreach(var g in rquery.ToArray())
                    {
                        dgv.Rows.Add(new object[] { g.ID, g.Login, g.PasswordHash, g.Salt, g.isAdmin });
                    }

                    break;
            }
        }
        #endregion

         //////////////////////////////////////////////
        // ДОБАВЛЕНИЕ ЭЛЕМЕНТОВ УПРАВЛЕНИЯ НА ФОРМУ //

        #region ДОБАВЛЕНИЕ ЭЛЕМЕНТОВ УПРАВЛЕНИЯ НА ФОРМУ
        private void createElements()
        {
            if(Role==Role.Guest)
            {
                btn_Add.Visible = false;
                btn_Update.Visible = false;
                btn_Delete.Visible = false;
            }

            switch(Table)
            {
                case Table.Firm:
                    createFirmElements();
                    break;

                case Table.SportEquipment:
                    createSportEquipmentElements();
                    break;

                case Table.Sportsman:
                    createSportsmanElements();
                    break;

                case Table.OwnEquipment:
                    createOwnEquipmentElements();
                    break;

                case Table.Register:
                    createRegisterElements();
                    break;
            }
        }

        private void createFirmElements()
        {
            this.Text = "Фирмы";

            lbl1.Text = "Название";
            lbl2.Text = "Количество";

            TextBox tb = new TextBox()
            {
                Name = "tb_Name",
                Location = new Point(117, 15),
                Size = new Size(201, 23),
                Font = new Font("Microsoft Sans Serif", 10.25f),
                MaxLength = 100
            };

            NumericUpDown num = new NumericUpDown()
            {
                Name = "num_Count",
                Location = new Point(117, 56),
                Size = new Size(201, 23),
                Font = new Font("Microsoft Sans Serif", 10.25f),
                Maximum = 1000000
            };

            this.Controls.AddRange(new Control[] { tb, num });
        }

        private void createSportEquipmentElements()
        {
            this.Text = "Спортивный инвентарь";

            lbl1.Text = "Название";
            lbl2.Text = "Цена";

            Label lbl3 = new Label()
            {
                Name = "lbl3",
                Text = "Фирма",
                Location = new Point(21, 103),
                Width = 60,
                Font = new Font("Microsoft Sans Serif", 10.25f)
            };

            TextBox tb = new TextBox()
            {
                Name = "tb_Name",
                Location = new Point(117, 15),
                Size = new Size(201, 23),
                Font = new Font("Microsoft Sans Serif", 10.25f),
                MaxLength = 100
            };

            NumericUpDown num = new NumericUpDown()
            {
                Name = "num_Price",
                Location = new Point(117, 56),
                Size = new Size(201, 23),
                Font = new Font("Microsoft Sans Serif", 10.25f),
                Maximum = 1000000,
                DecimalPlaces = 2
            };

            ComboBox cb = new ComboBox()
            {
                Name = "cb_Firm",
                Location = new Point(117, 100),
                Size = new Size(201, 23),
                Font = new Font("Microsoft Sans Serif", 10.25f),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            var query = from f in db.Firms
                        select f.Name;

            cb.Items.AddRange(query.ToArray());

            this.Controls.AddRange(new Control[] { lbl3, tb, num, cb });
        }

        private void createSportsmanElements()
        {
            this.Text = "Спортсмены";

            lbl1.Text = "Имя";
            lbl2.Text = "Возраст";

            TextBox tb = new TextBox()
            {
                Name = "tb_Name",
                Location = new Point(97, 15),
                Size = new Size(201, 23),
                Font = new Font("Microsoft Sans Serif", 10.25f),
                MaxLength = 100
            };

            NumericUpDown num = new NumericUpDown()
            {
                Name = "num_Age",
                Location = new Point(97, 56),
                Size = new Size(201, 23),
                Font = new Font("Microsoft Sans Serif", 10.25f),
                Maximum = 120
            };

            this.Controls.AddRange(new Control[] { tb, num });
        }

        private void createOwnEquipmentElements()
        {
            this.Text = "Личный инвентарь";

            lbl1.Text = "Спортсмен";
            lbl2.Text = "Инвентарь";

            Label lbl3 = new Label()
            {
                Name = "lbl3",
                Text = "Количество",
                Location = new Point(21, 103),
                Width = 90,
                Font = new Font("Microsoft Sans Serif", 10.25f)
            };

            ComboBox cb1 = new ComboBox()
            {
                Name = "cb_Sportsman",
                Location = new Point(117, 15),
                Size = new Size(201, 23),
                Font = new Font("Microsoft Sans Serif", 10.25f),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            ComboBox cb2 = new ComboBox()
            {
                Name = "cb_Equipment",
                Location = new Point(117, 56),
                Size = new Size(201, 23),
                Font = new Font("Microsoft Sans Serif", 10.25f),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            NumericUpDown num = new NumericUpDown()
            {
                Name = "num_Count",
                Location = new Point(117, 100),
                Size = new Size(201, 23),
                Font = new Font("Microsoft Sans Serif", 10.25f),
                Minimum = 1,
                Maximum = 1000
            };

            var query = from s in db.Sportsmen
                        select s.Name;

            cb1.Items.AddRange(query.ToArray());

            query = from e in db.SportEquipments
                    select e.Name;

            cb2.Items.AddRange(query.ToArray());


            this.Controls.AddRange(new Control[] { lbl3, cb1, cb2, num });
        }

        private void createRegisterElements()
        {
            this.Text = "Данные пользователей";

            lbl1.Text = "Логин";
            lbl2.Text = "Пароль";

            Label lbl3 = new Label()
            {
                Name = "lbl4",
                Text = "Админ",
                Location = new Point(21, 103),
                Width = 50,
                Font = new Font("Microsoft Sans Serif", 10.25f)
            };

            TextBox tb1 = new TextBox()
            {
                Name = "tb_Login",
                Location = new Point(87, 15),
                Size = new Size(201, 23),
                Font = new Font("Microsoft Sans Serif", 10.25f),
                MaxLength = 20
            };

            TextBox tb2 = new TextBox()
            {
                Name = "tb_Password",
                Location = new Point(87, 56),
                Size = new Size(201, 23),
                Font = new Font("Microsoft Sans Serif", 10.25f)
            };

            CheckBox chb = new CheckBox()
            {
                Name = "chb_Admin",
                Location = new Point(87, 100)
            };

            this.Controls.AddRange(new Control[] { lbl3, tb1, tb2, chb });
        }

        #endregion

         ///////////////////////////////////////////
        //////////// ОБНОВЛЕНИЕ ДАННЫХ ////////////

        #region ОБНОВЛЕНИЕ ДАННЫХ
        private void btn_Update_Click(object sender, EventArgs e)
        {
            switch(Table)
            {
                case Table.Firm:
                    updateFirm();
                    break;

                case Table.SportEquipment:
                    updateSportEquipment();
                    break;

                case Table.Sportsman:
                    updateSportsman();
                    break;

                case Table.OwnEquipment:
                    updateOwnEquipment();
                    break;

                case Table.Register:
                    updateRegister();
                    break;
            }

            CallReFill();
        }

        private void updateFirm()
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var con = this.Controls;
            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            var name = ((TextBox)con["tb_Name"]).Text;
            var count = ((NumericUpDown)con["num_Count"]).Value;


            if(db.Firms.Count()==0)
            {
                MessageBox.Show("Объектов нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (name == "")
            {
                MessageBox.Show("Поле не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var query = from f in db.Firms
                        where f.Name == name
                        select f;

            if (query.Count()!=0 && id != query.First().ID)
            {
                MessageBox.Show("Такая фирма уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var row = dgv.SelectedRows[0];
            var firm = db.Firms.Find(row.Cells[0].Value);

            row.Cells[1].Value = name;
            row.Cells[2].Value = count;

            firm.Name = name;
            firm.EmployeeCount = (int)count;

            db.SaveChanges();
        }

        private void updateSportEquipment()
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var con = this.Controls;
            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            var name = ((TextBox)con["tb_Name"]).Text;
            var price = ((NumericUpDown)con["num_Price"]).Value;
            var firm = ((ComboBox)con["cb_Firm"]).Text;

            
            if(db.SportEquipments.Count()== 0)
            {
                MessageBox.Show("Объектов нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(name == "")
            {
                MessageBox.Show("Поле не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var query = from n in db.SportEquipments
                        where n.Name == name
                        select n;

            if(query.Count()!=0 && id != query.First().ID)
            {
                MessageBox.Show("Такой инвентарь уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var row = dgv.SelectedRows[0];
            var equip = db.SportEquipments.Find(row.Cells[0].Value);

            row.Cells[1].Value = name;
            row.Cells[2].Value = price;
            row.Cells[3].Value = firm;

            int firmId = (from n in db.Firms where n.Name == firm select n.ID).First();

            equip.Name = name;
            equip.Price = price;
            equip.FirmID = firmId;

            db.SaveChanges();
        }

        private void updateSportsman()
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var con = this.Controls;
            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            var name = ((TextBox)con["tb_Name"]).Text;
            var age = ((NumericUpDown)con["num_Age"]).Value;


            if (db.Sportsmen.Count() == 0)
            {
                MessageBox.Show("Объектов нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (name == "")
            {
                MessageBox.Show("Поле не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var query = from n in db.Sportsmen
                        where n.Name == name
                        select n;

            if (query.Count() != 0 && id != query.First().ID)
            {
                MessageBox.Show("Такой спортсмен уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var row = dgv.SelectedRows[0];
            var sportsman = db.Sportsmen.Find(row.Cells[0].Value);

            row.Cells[1].Value = name;
            row.Cells[2].Value = age;

            sportsman.Name = name;
            sportsman.Age = (int)age;

            db.SaveChanges();
        }

        private void updateOwnEquipment()
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var con = this.Controls;
            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            var sportsman = ((ComboBox)con["cb_Sportsman"]).Text;
            var equipment = ((ComboBox)con["cb_Equipment"]).Text;
            var count = ((NumericUpDown)con["num_Count"]).Value;


            if(db.OwnEquipments.Count()==0)
            {
                MessageBox.Show("Объектов нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ids = (from n in db.Sportsmen where n.Name == sportsman select n.ID).First();
            int ide = (from n in db.SportEquipments where n.Name == equipment select n.ID).First();

            var query = from n in db.OwnEquipments
                        where n.SportsmanID == ids && n.EquipmentID == ide
                        select n;

            if(query.Count()!=0 && id != query.First().ID)
            {
                MessageBox.Show("Такая связь уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var row = dgv.SelectedRows[0];
            var own = db.OwnEquipments.Find(row.Cells[0].Value);

            row.Cells[1].Value = sportsman;
            row.Cells[2].Value = equipment;
            row.Cells[3].Value = count;

            own.SportsmanID = ids;
            own.EquipmentID = ide;
            own.Count = (int)count;

            db.SaveChanges();
        }

        private void updateRegister()
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var con = this.Controls;
            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            var login = ((TextBox)con["tb_Login"]).Text;
            var password = ((TextBox)con["tb_Password"]).Text;
            string salt;
            var chb = ((CheckBox)con["chb_Admin"]).Checked;


            if(db.Registers.Count()==0)
            {
                MessageBox.Show("Объектов нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (login == "")
            {
                MessageBox.Show("Поле не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var query = from r in db.Registers
                        where r.Login == login
                        select r;

            if (query.Count() != 0 && id != query.First().ID)
            {
                MessageBox.Show("Такой логин уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var row = dgv.SelectedRows[0];
            var reg = db.Registers.Find(row.Cells[0].Value);

            if (password == "")
            {
                password = row.Cells[2].Value.ToString();
                salt = row.Cells[3].Value.ToString();
            }
            else
            {
                salt = Salt_Create();
                password = Hash_Create(password + salt);
            }

            row.Cells[1].Value = login;
            row.Cells[2].Value = password;
            row.Cells[3].Value = salt;
            row.Cells[4].Value = chb;

            reg.Login = login;
            reg.PasswordHash = password;
            reg.Salt = salt.ToString();
            reg.isAdmin = chb;

            db.SaveChanges();
        }
        #endregion

         ///////////////////////////////////////////
        //////////// ДОБАВЛЕНИЕ ДАННЫХ ////////////

        #region ДОБАВЛЕНИЕ ДАННЫХ

        private void btn_Add_Click(object sender, EventArgs e)
        {
            switch (Table)
            {
                case Table.Firm:
                    addFirm();
                    break;

                case Table.SportEquipment:
                    addSportEquipment();
                    break;

                case Table.Sportsman:
                    addSportsman();
                    break;

                case Table.OwnEquipment:
                    addOwnEquipment();
                    break;

                case Table.Register:
                    addRegister();
                    break;
            }

            CallReFill();
        }

        private void addFirm()
        {
            var con = this.Controls;
            int id;
            var name = ((TextBox)con["tb_Name"]).Text;
            var count = ((NumericUpDown)con["num_Count"]).Value;

            
            if (db.Firms.Count() == 0)
                id = 1;
            else
                id = db.Firms.Max(p => p.ID) + 1;

            if (name == "")
            {
                MessageBox.Show("Поле не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var query = from f in db.Firms
                        where f.Name == name
                        select f;

            if (query.Count() != 0)
            {
                MessageBox.Show("Такая фирма уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            dgv.Rows.Add(new object[] { id, name, count });

            Firm firm = new Firm()
            {
                ID = id,
                Name = name,
                EmployeeCount = (int)count
            };

            db.Firms.Add(firm);

            db.SaveChanges();
        }

        private void addSportEquipment()
        {
            var con = this.Controls;
            int id;
            var name = ((TextBox)con["tb_Name"]).Text;
            var price = ((NumericUpDown)con["num_Price"]).Value;
            var firm = ((ComboBox)con["cb_Firm"]).Text;


            if (db.SportEquipments.Count() == 0)
                id = 1;
            else
                id = db.SportEquipments.Max(p => p.ID) + 1;

            if (name == "" || firm == "")
            {
                MessageBox.Show("Поле не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var query = from n in db.SportEquipments
                        where n.Name == name
                        select n;

            if (query.Count() != 0)
            {
                MessageBox.Show("Такой инвентарь уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            dgv.Rows.Add(new object[] { id, name, price, firm });

            int firmId = (from n in db.Firms where n.Name == firm select n.ID).First();

            SportEquipment equip = new SportEquipment()
            {
                ID = id,
                Name = name,
                Price = price,
                FirmID = firmId
            };

            db.SportEquipments.Add(equip);

            db.SaveChanges();
        }

        private void addSportsman()
        {
            var con = this.Controls;
            int id;
            var name = ((TextBox)con["tb_Name"]).Text;
            var age = ((NumericUpDown)con["num_Age"]).Value;

            
            if (db.Sportsmen.Count() == 0)
                id = 1;
            else
                id = db.Sportsmen.Max(p => p.ID) + 1;

            if (name == "")
            {
                MessageBox.Show("Поле не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var query = from n in db.Sportsmen
                        where n.Name == name
                        select n;

            if (query.Count() != 0)
            {
                MessageBox.Show("Такой спортсмен уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            dgv.Rows.Add(new object[] { id, name, age });

            Sportsman sportsman = new Sportsman()
            {
                ID = id,
                Name = name,
                Age = (int)age
            };

            db.Sportsmen.Add(sportsman);

            db.SaveChanges();
        }

        private void addOwnEquipment()
        {
            var con = this.Controls;
            int id;
            var sportsman = ((ComboBox)con["cb_Sportsman"]).Text;
            var equipment = ((ComboBox)con["cb_Equipment"]).Text;
            var count = ((NumericUpDown)con["num_Count"]).Value;

            
            if (db.OwnEquipments.Count() == 0)
                id = 1;
            else
                id = db.OwnEquipments.Max(p => p.ID) + 1;

            if (sportsman == "" || equipment == "")
            {
                MessageBox.Show("Поле не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ids = (from n in db.Sportsmen where n.Name == sportsman select n.ID).First();
            int eid = (from n in db.SportEquipments where n.Name == equipment select n.ID).First();

            var query = from n in db.OwnEquipments
                        where n.SportsmanID == ids && n.EquipmentID == eid
                        select n;

            if (query.Count() != 0)
            {
                MessageBox.Show("Такая связь уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            dgv.Rows.Add(new object[] { id, sportsman, equipment, count });

            OwnEquipment own = new OwnEquipment()
            {
                ID = id,
                SportsmanID = ids,
                EquipmentID = eid,
                Count = (int)count
            };

            db.OwnEquipments.Add(own);

            db.SaveChanges();
        }

        private void addRegister()
        {
            var con = this.Controls;
            int id;
            var login = ((TextBox)con["tb_Login"]).Text;
            var password = ((TextBox)con["tb_Password"]).Text;
            string salt;
            var chb = ((CheckBox)con["chb_Admin"]).Checked;

            
            if (db.Registers.Count() == 0)
                id = 1;
            else
                id = db.Registers.Max(p => p.ID) + 1;

            if (login == "" || password == "")
            {
                MessageBox.Show("Поле не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var query = from r in db.Registers
                        where r.Login == login
                        select r;

            if (query.Count() != 0)
            {
                MessageBox.Show("Такой логин уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            salt = Salt_Create();
            password = Hash_Create(password + salt);

            dgv.Rows.Add(new object[] { id, login, password, salt, chb });

            Register reg = new Register()
            {
                ID = id,
                Login = login,
                PasswordHash = password,
                Salt = salt.ToString(),
                isAdmin = chb
            };

            db.Registers.Add(reg);

            db.SaveChanges();
        }

        #endregion

         /////////////////////////////////////////
        //////////// УДАЛЕНИЕ ДАННЫХ ////////////

        #region УДАЛЕНИЕ ДАННЫХ

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            switch (Table)
            {
                case Table.Firm:
                    deleteFirm();
                    break;

                case Table.SportEquipment:
                    deleteSportEquipment();
                    break;

                case Table.Sportsman:
                    deleteSportsman();
                    break;

                case Table.OwnEquipment:
                    deleteOwnEquipment();
                    break;

                case Table.Register:
                    deleteRegister();
                    break;
            }

            CallReFill();
        }

        private void deleteFirm()
        {
            if(dgv.SelectedRows.Count==0)
            {
                MessageBox.Show("Выделите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Firms.Count() == 0)
            {
                MessageBox.Show("Объектов нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            var firm = db.Firms.Find(id);

            if (firm.SportEquipments.Count != 0)
            {
                MessageBox.Show("Нельзя удалить фирму, у которой есть инвентарь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);

            db.Firms.Remove(firm);

            db.SaveChanges();
        }

        private void deleteSportEquipment()
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.SportEquipments.Count() == 0)
            {
                MessageBox.Show("Объектов нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            var equip = db.SportEquipments.Find(id);

            if (equip.OwnEquipments.Count != 0)
            {
                MessageBox.Show("Нельзя удалить инвентарь, у которого есть владелец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);

            db.SportEquipments.Remove(equip);

            db.SaveChanges();
        }

        private void deleteSportsman()
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Sportsmen.Count() == 0)
            {
                MessageBox.Show("Объектов нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            var sport = db.Sportsmen.Find(id);

            if (sport.OwnEquipments.Count != 0)
            {
                MessageBox.Show("Нельзя удалить спортсмена, у которого есть инвентарь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);

            db.Sportsmen.Remove(sport);

            db.SaveChanges();
        }

        private void deleteOwnEquipment()
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.OwnEquipments.Count()==0)
            {
                MessageBox.Show("Объектов нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            var own = db.OwnEquipments.Find(id);


            dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);
            
            db.OwnEquipments.Remove(own);

            db.SaveChanges();
        }

        private void deleteRegister()
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Registers.Count() == 0)
            {
                MessageBox.Show("Объектов нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            var reg = db.Registers.Find(id);

            dgv.Rows.RemoveAt(dgv.SelectedRows[0].Index);

            db.Registers.Remove(reg);

            db.SaveChanges();
        }

        #endregion

         /////////////////////////////////////////
        ////////// СТАНДАРТНЫЕ ЗАПРОСЫ //////////

        #region СТАНДАРТНЫЕ ЗАПРОСЫ

        private void cb_Column_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Column.Text == "")
                return;

            dgv.Rows.Clear();
            fillDgv();

            cb_Value.Items.Clear();
            fill_cb_Value();
        }

        private void cb_Value_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Value.Text == "")
                return;

            dgv.Rows.Clear();
            fillDgv();

            for (int i = 1; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].HeaderText == cb_Column.Text)
                {
                    for (int j = 0; j < dgv.Rows.Count; j++)
                    {
                        var val = dgv.Rows[j].Cells[i].Value;

                        if (val.ToString() != cb_Value.Text)
                        {
                            dgv.Rows.RemoveAt(j);
                            j--;
                        }
                    }
                }
            }
        }

        private void btn_Drop_Click(object sender, EventArgs e)
        {
            cb_Column.Items.Clear();
            cb_Value.Items.Clear();

            fill_cb_Column();

            dgv.Rows.Clear();

            fillDgv();
        }

        private void fill_cb_Column()
        {
            for(int i = 1; i < dgv.Columns.Count; i++)
            {
                if(dgv.Columns[i].Visible==true)
                    cb_Column.Items.Add(dgv.Columns[i].HeaderText);
            }
        }

        private void fill_cb_Value()
        {
            for(int i = 1; i < dgv.Columns.Count; i++)
            {
                if(dgv.Columns[i].HeaderText == cb_Column.Text)
                {
                    for(int j = 0; j < dgv.Rows.Count; j++)
                    {
                        var val = dgv.Rows[j].Cells[i].Value;

                        if (!cb_Value.Items.Contains(val))
                            cb_Value.Items.Add(val);
                    }    
                }
            }
        }

        #endregion

        /////////////////////////////////
        ///// ДОПОЛНИТЕЛЬНЫЕ МЕТОДЫ /////

        #region ДОПОЛНИТЕЛЬНЫЕ МЕТОДЫ

        // Вызывает перезаполнение открытых форм с таблицами
        private void CallReFill()
        {
            var forms = Application.OpenForms;
            for (int i = 2; i < forms.Count; i++)
            {
                if (forms[i].Name != this.Name)
                    ((Form_Table)forms[i]).ReFillForm();
            }
        }

        // Обновление содержимого формы
        private void ReFillForm()
        {
            var con = this.Controls;
            ComboBox cb;

            if (Table == Table.SportEquipment)
            {
                cb = (ComboBox)con["cb_Firm"];

                cb.Items.Clear();
                cb.Items.AddRange(db.Firms.Select(p => p.Name).ToArray());
            }

            if (Table == Table.OwnEquipment)
            {
                cb = (ComboBox)con["cb_Sportsman"];

                cb.Items.Clear();
                cb.Items.AddRange(db.Sportsmen.Select(p => p.Name).ToArray());

                cb = (ComboBox)con["cb_Equipment"];

                cb.Items.Clear();
                cb.Items.AddRange(db.SportEquipments.Select(p => p.Name).ToArray());
            }

            dgv.Rows.Clear();
            fillDgv();

            cb_Value.Items.Clear();
            fill_cb_Value();
        }

        // При смене выделения меняется содержимое элементов управления в
        // зависимости от того, какая таблица сейчас отображается на форме
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                return;

            switch (Table)
            {
                case Table.Firm:
                    ((TextBox)this.Controls["tb_Name"]).Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                    ((NumericUpDown)this.Controls["num_Count"]).Value = Convert.ToDecimal(dgv.SelectedRows[0].Cells[2].Value);
                    break;

                case Table.SportEquipment:
                    ((TextBox)this.Controls["tb_Name"]).Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                    ((NumericUpDown)this.Controls["num_Price"]).Value = Convert.ToDecimal(dgv.SelectedRows[0].Cells[2].Value);
                    ((ComboBox)this.Controls["cb_Firm"]).Text = dgv.SelectedRows[0].Cells[3].Value.ToString();
                    break;

                case Table.Sportsman:
                    ((TextBox)this.Controls["tb_Name"]).Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                    ((NumericUpDown)this.Controls["num_Age"]).Value = Convert.ToDecimal(dgv.SelectedRows[0].Cells[2].Value);
                    break;

                case Table.OwnEquipment:
                    ((ComboBox)this.Controls["cb_Sportsman"]).Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                    ((ComboBox)this.Controls["cb_Equipment"]).Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
                    ((NumericUpDown)this.Controls["num_Count"]).Value = Convert.ToDecimal(dgv.SelectedRows[0].Cells[3].Value);
                    break;

                case Table.Register:
                    ((TextBox)this.Controls["tb_Login"]).Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                    ((CheckBox)this.Controls["chb_Admin"]).Checked = Convert.ToBoolean(dgv.SelectedRows[0].Cells[4].Value);
                    break;
            }
        }

        // Создание соли для пароля пользователя
        private string Salt_Create()
        {
            Random rand = new Random();
            string s = "";
            for (int i = 0; i < 10; i++)
            {
                s += (char)rand.Next(33, 126);
            }
            return s;
        }

        // Принимает пароль+соль в виде строки, возвращает хэш-строку пароля
        private string Hash_Create(string password)
        {
            byte[] passBuf = new byte[password.Length];
            for (int i = 0; i < password.Length; i++)
            {
                passBuf[i] = Convert.ToByte(password[i]);
            }

            string resultHash = "";
            using (SHA256 hash = new SHA256Managed())
            {
                foreach (byte b in hash.ComputeHash(passBuf))
                {
                    resultHash += b.ToString("x2");
                }
            }
            return resultHash;
        }
        #endregion

    }
}
