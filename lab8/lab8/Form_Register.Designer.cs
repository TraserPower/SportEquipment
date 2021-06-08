namespace lab8
{
    partial class Form_Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_IncorrectPass = new System.Windows.Forms.Label();
            this.lbl_Exists = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.lbl_Register = new System.Windows.Forms.Label();
            this.lbl_Empty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_IncorrectPass
            // 
            this.lbl_IncorrectPass.AutoSize = true;
            this.lbl_IncorrectPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_IncorrectPass.ForeColor = System.Drawing.Color.Red;
            this.lbl_IncorrectPass.Location = new System.Drawing.Point(340, 217);
            this.lbl_IncorrectPass.Name = "lbl_IncorrectPass";
            this.lbl_IncorrectPass.Size = new System.Drawing.Size(138, 15);
            this.lbl_IncorrectPass.TabIndex = 20;
            this.lbl_IncorrectPass.Text = "Некорректный пароль";
            this.lbl_IncorrectPass.Visible = false;
            // 
            // lbl_Exists
            // 
            this.lbl_Exists.AutoSize = true;
            this.lbl_Exists.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Exists.ForeColor = System.Drawing.Color.Red;
            this.lbl_Exists.Location = new System.Drawing.Point(340, 150);
            this.lbl_Exists.Name = "lbl_Exists";
            this.lbl_Exists.Size = new System.Drawing.Size(170, 15);
            this.lbl_Exists.TabIndex = 19;
            this.lbl_Exists.Text = "Такой логин уже существует";
            this.lbl_Exists.Visible = false;
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Register.Location = new System.Drawing.Point(203, 317);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(127, 38);
            this.btn_Register.TabIndex = 18;
            this.btn_Register.Text = "Регистрация";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Password.Location = new System.Drawing.Point(115, 213);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(205, 24);
            this.tb_Password.TabIndex = 17;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Password.Location = new System.Drawing.Point(36, 217);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(61, 18);
            this.lbl_Password.TabIndex = 16;
            this.lbl_Password.Text = "Пароль";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Login.Location = new System.Drawing.Point(36, 150);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(50, 18);
            this.lbl_Login.TabIndex = 15;
            this.lbl_Login.Text = "Логин";
            // 
            // tb_Login
            // 
            this.tb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Login.Location = new System.Drawing.Point(115, 146);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(205, 24);
            this.tb_Login.TabIndex = 14;
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Register.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Register.Location = new System.Drawing.Point(148, 31);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(239, 42);
            this.lbl_Register.TabIndex = 13;
            this.lbl_Register.Text = "Регистрация";
            // 
            // lbl_Empty
            // 
            this.lbl_Empty.AutoSize = true;
            this.lbl_Empty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Empty.ForeColor = System.Drawing.Color.Red;
            this.lbl_Empty.Location = new System.Drawing.Point(340, 150);
            this.lbl_Empty.Name = "lbl_Empty";
            this.lbl_Empty.Size = new System.Drawing.Size(93, 15);
            this.lbl_Empty.TabIndex = 19;
            this.lbl_Empty.Text = "Введите логин";
            this.lbl_Empty.Visible = false;
            // 
            // Form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 416);
            this.Controls.Add(this.lbl_IncorrectPass);
            this.Controls.Add(this.lbl_Empty);
            this.Controls.Add(this.lbl_Exists);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.lbl_Register);
            this.Name = "Form_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма регистрации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IncorrectPass;
        private System.Windows.Forms.Label lbl_Exists;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.Label lbl_Register;
        private System.Windows.Forms.Label lbl_Empty;
    }
}