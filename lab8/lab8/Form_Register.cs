using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace lab8
{
    public partial class Form_Register : Form
    {
        Sport_Equipment db;
        public Form_Register()
        {
            InitializeComponent();
            db = new Sport_Equipment();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string login = tb_Login.Text;
            string password = tb_Password.Text;

            if(login == "")
            {
                lbl_Empty.Visible = true;
                return;
            }
            lbl_Empty.Visible = false;

            var query = from r in db.Registers
                        where r.Login == login
                        select r;

            if (query.Count() != 0) 
            {
                lbl_Exists.Visible = true;
                return;
            }
            lbl_Exists.Visible = false;

            //проверки на соответствие пароля требованиям
            if (password == "")
            {
                lbl_IncorrectPass.Visible = true;
                return;
            }
            lbl_IncorrectPass.Visible = false;

            string salt = Salt_Create();
            string hash = Hash_Create(password + salt);

            Register reg = new Register();
            int id;

            if (db.Registers.Count() == 0)
                id = 1;
            else
                id = db.Registers.Max(p => p.ID) + 1;
            
            reg.ID = id;
            reg.Login = login;
            reg.PasswordHash = hash;
            reg.Salt = salt;
            reg.isAdmin = false;

            db.Registers.Add(reg);
            db.SaveChanges();

            this.Close();
        }

        // Создание соли для пароля нового пользователя
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
    }
}
