namespace lab8
{
    partial class Form_Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_IncorrectPass = new System.Windows.Forms.Label();
            this.lbl_IncorrectLogin = new System.Windows.Forms.Label();
            this.link_Register = new System.Windows.Forms.LinkLabel();
            this.btn_Logging = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.lbl_Logging = new System.Windows.Forms.Label();
            this.btn_Guest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_IncorrectPass
            // 
            this.lbl_IncorrectPass.AutoSize = true;
            this.lbl_IncorrectPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_IncorrectPass.ForeColor = System.Drawing.Color.Red;
            this.lbl_IncorrectPass.Location = new System.Drawing.Point(361, 209);
            this.lbl_IncorrectPass.Name = "lbl_IncorrectPass";
            this.lbl_IncorrectPass.Size = new System.Drawing.Size(112, 15);
            this.lbl_IncorrectPass.TabIndex = 18;
            this.lbl_IncorrectPass.Text = "Неверный пароль";
            this.lbl_IncorrectPass.Visible = false;
            // 
            // lbl_IncorrectLogin
            // 
            this.lbl_IncorrectLogin.AutoSize = true;
            this.lbl_IncorrectLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_IncorrectLogin.ForeColor = System.Drawing.Color.Red;
            this.lbl_IncorrectLogin.Location = new System.Drawing.Point(361, 142);
            this.lbl_IncorrectLogin.Name = "lbl_IncorrectLogin";
            this.lbl_IncorrectLogin.Size = new System.Drawing.Size(103, 15);
            this.lbl_IncorrectLogin.TabIndex = 17;
            this.lbl_IncorrectLogin.Text = "Неверный логин";
            this.lbl_IncorrectLogin.Visible = false;
            // 
            // link_Register
            // 
            this.link_Register.AutoSize = true;
            this.link_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.link_Register.Location = new System.Drawing.Point(386, 365);
            this.link_Register.Name = "link_Register";
            this.link_Register.Size = new System.Drawing.Size(151, 18);
            this.link_Register.TabIndex = 16;
            this.link_Register.TabStop = true;
            this.link_Register.Text = "Зарегистрироваться";
            this.link_Register.VisitedLinkColor = System.Drawing.Color.Blue;
            this.link_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Register_LinkClicked);
            // 
            // btn_Logging
            // 
            this.btn_Logging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Logging.Location = new System.Drawing.Point(200, 293);
            this.btn_Logging.Name = "btn_Logging";
            this.btn_Logging.Size = new System.Drawing.Size(153, 40);
            this.btn_Logging.TabIndex = 15;
            this.btn_Logging.Text = "Войти";
            this.btn_Logging.UseVisualStyleBackColor = true;
            this.btn_Logging.Click += new System.EventHandler(this.btn_Logging_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Password.Location = new System.Drawing.Point(133, 205);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(205, 24);
            this.tb_Password.TabIndex = 14;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Password.Location = new System.Drawing.Point(54, 209);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(61, 18);
            this.lbl_Password.TabIndex = 13;
            this.lbl_Password.Text = "Пароль";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Login.Location = new System.Drawing.Point(54, 142);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(50, 18);
            this.lbl_Login.TabIndex = 12;
            this.lbl_Login.Text = "Логин";
            // 
            // tb_Login
            // 
            this.tb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Login.Location = new System.Drawing.Point(133, 138);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(205, 24);
            this.tb_Login.TabIndex = 11;
            // 
            // lbl_Logging
            // 
            this.lbl_Logging.AutoSize = true;
            this.lbl_Logging.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Logging.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Logging.Location = new System.Drawing.Point(141, 24);
            this.lbl_Logging.Name = "lbl_Logging";
            this.lbl_Logging.Size = new System.Drawing.Size(287, 42);
            this.lbl_Logging.TabIndex = 10;
            this.lbl_Logging.Text = "Вход в систему";
            // 
            // btn_Guest
            // 
            this.btn_Guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Guest.Location = new System.Drawing.Point(413, 321);
            this.btn_Guest.Name = "btn_Guest";
            this.btn_Guest.Size = new System.Drawing.Size(100, 40);
            this.btn_Guest.TabIndex = 19;
            this.btn_Guest.Text = "Войти как гость";
            this.btn_Guest.UseVisualStyleBackColor = true;
            this.btn_Guest.Click += new System.EventHandler(this.btn_Guest_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 404);
            this.Controls.Add(this.btn_Guest);
            this.Controls.Add(this.lbl_IncorrectPass);
            this.Controls.Add(this.lbl_IncorrectLogin);
            this.Controls.Add(this.link_Register);
            this.Controls.Add(this.btn_Logging);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.lbl_Logging);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма для аутентификации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_IncorrectPass;
        private System.Windows.Forms.Label lbl_IncorrectLogin;
        private System.Windows.Forms.LinkLabel link_Register;
        private System.Windows.Forms.Button btn_Logging;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.Label lbl_Logging;
        private System.Windows.Forms.Button btn_Guest;
    }
}

