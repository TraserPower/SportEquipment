using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form_Main : Form
    {
        public Role Role { get; set; }
        bool isUnlogin = false;

        public Form_Main(Role role)
        {
            InitializeComponent();

            Role = role;

            if (role == Role.Admin)
                btn_Register.Visible = true;
        }

        private void btn_Firm_Click(object sender, EventArgs e)
        {
            Table table = Table.Firm;
            Form_Table form = GetForm(table);

            if(form != null)
            {
                form.Activate();
                return;
            }

            form = new Form_Table(table, Role) {Name = "Firm" };
            form.Show();
        }

        private void btn_SportEquipment_Click(object sender, EventArgs e)
        {
            Table table = Table.SportEquipment;
            Form_Table form = GetForm(table);

            if (form != null)
            {
                form.Activate();
                return;
            }

            form = new Form_Table(table, Role) {Name = "SportEquipment" };
            form.Show();
        }

        private void btn_Sportsman_Click(object sender, EventArgs e)
        {
            Table table = Table.Sportsman;
            Form_Table form = GetForm(table);

            if (form != null)
            {
                form.Activate();
                return;
            }

            form = new Form_Table(table, Role) {Name = "Sportsman" };
            form.Show();
        }

        private void btn_OwnEquipment_Click(object sender, EventArgs e)
        {
            Table table = Table.OwnEquipment;
            Form_Table form = GetForm(table);

            if (form != null)
            {
                form.Activate();
                return;
            }

            form = new Form_Table(table, Role) {Name = "OwnEquipment" };
            form.Show();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Table table = Table.Register;
            Form_Table form = GetForm(table);

            if (form != null)
            {
                form.Activate();
                return;
            }

            form = new Form_Table(table, Role) {Name = "Register" };
            form.Show();
        }

        //Если находится открытая форма таблицы, то возвращается ссылка на нее, иначе возвращается null
        private Form_Table GetForm(Table table)
        {
            var forms = Application.OpenForms;

            for (int i = 2; i < forms.Count; i++)
            {
                if (((Form_Table)forms[i]).Table == table)
                    return (Form_Table)forms[i];
            }

            return null;
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!isUnlogin)
                Application.Exit();

            foreach(Table t in Enum.GetValues(typeof(Table)))
            {
                var form = GetForm(t);

                if (form != null)
                    form.Close();
            }
        }

        private void link_Unlogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isUnlogin = true;
            this.Close();
        }
    }
}
