using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace lab8
{
    public partial class Form_Login : Form
    {
        Sport_Equipment db;
        public Form_Login()
        {
            InitializeComponent();

            db = new Sport_Equipment();
        }

        private void btn_Logging_Click(object sender, EventArgs e)
        {
            string login = tb_Login.Text;
            string password = tb_Password.Text;

            var query = from r in db.Registers
                        where r.Login == login
                        select r;

            // Проверка соответствия введенного логина и существующих в БД
            if(query.Count()==0)
            {
                lbl_IncorrectLogin.Visible = true;
                return;
            }
            lbl_IncorrectLogin.Visible = false;

            var register = query.First();
            var hash = Hash_Create(password + register.Salt);

            // Проверка правильности введенного пароля
            if(hash != register.PasswordHash)
            {
                lbl_IncorrectPass.Visible = true;
                return;
            }
            lbl_IncorrectPass.Visible = false;

            db.SaveChanges();

            Role role;
            if (register.isAdmin)
                role = Role.Admin;
            else
                role = Role.User;

            using (Form_Main form = new Form_Main(role))
            {
                Hide();
                form.ShowDialog();
                Show();
            }
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
                byte[] hashRes = hash.ComputeHash(passBuf);

                foreach (byte b in hashRes)
                {
                    resultHash += b.ToString("x2");
                }
            }
            return resultHash;
        }

        // Кнопка для вхождения в систему в роли "гостя"
        private void btn_Guest_Click(object sender, EventArgs e)
        {
            using(Form_Main form = new Form_Main(Role.Guest))
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }

        // Кликабельная ссылка для регистрации нового пользователя
        private void link_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Form_Register form = new Form_Register())
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }
    }
}
