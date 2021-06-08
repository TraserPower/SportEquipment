namespace lab8
{
    partial class Form_Main
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
            this.btn_Firm = new System.Windows.Forms.Button();
            this.btn_SportEquipment = new System.Windows.Forms.Button();
            this.btn_OwnEquipment = new System.Windows.Forms.Button();
            this.btn_Sportsman = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.link_Unlogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_Firm
            // 
            this.btn_Firm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Firm.Location = new System.Drawing.Point(110, 90);
            this.btn_Firm.Name = "btn_Firm";
            this.btn_Firm.Size = new System.Drawing.Size(181, 92);
            this.btn_Firm.TabIndex = 0;
            this.btn_Firm.Text = "Фирмы";
            this.btn_Firm.UseVisualStyleBackColor = true;
            this.btn_Firm.Click += new System.EventHandler(this.btn_Firm_Click);
            // 
            // btn_SportEquipment
            // 
            this.btn_SportEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SportEquipment.Location = new System.Drawing.Point(313, 90);
            this.btn_SportEquipment.Name = "btn_SportEquipment";
            this.btn_SportEquipment.Size = new System.Drawing.Size(181, 92);
            this.btn_SportEquipment.TabIndex = 0;
            this.btn_SportEquipment.Text = "Спорт инвентарь";
            this.btn_SportEquipment.UseVisualStyleBackColor = true;
            this.btn_SportEquipment.Click += new System.EventHandler(this.btn_SportEquipment_Click);
            // 
            // btn_OwnEquipment
            // 
            this.btn_OwnEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OwnEquipment.Location = new System.Drawing.Point(313, 193);
            this.btn_OwnEquipment.Name = "btn_OwnEquipment";
            this.btn_OwnEquipment.Size = new System.Drawing.Size(181, 92);
            this.btn_OwnEquipment.TabIndex = 0;
            this.btn_OwnEquipment.Text = "Личный инвентарь";
            this.btn_OwnEquipment.UseVisualStyleBackColor = true;
            this.btn_OwnEquipment.Click += new System.EventHandler(this.btn_OwnEquipment_Click);
            // 
            // btn_Sportsman
            // 
            this.btn_Sportsman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Sportsman.Location = new System.Drawing.Point(110, 193);
            this.btn_Sportsman.Name = "btn_Sportsman";
            this.btn_Sportsman.Size = new System.Drawing.Size(181, 92);
            this.btn_Sportsman.TabIndex = 0;
            this.btn_Sportsman.Text = "Спортсмены";
            this.btn_Sportsman.UseVisualStyleBackColor = true;
            this.btn_Sportsman.Click += new System.EventHandler(this.btn_Sportsman_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблицы";
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Register.Location = new System.Drawing.Point(209, 298);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(181, 92);
            this.btn_Register.TabIndex = 0;
            this.btn_Register.Text = "Данные об операторах";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Visible = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // link_Unlogin
            // 
            this.link_Unlogin.AutoSize = true;
            this.link_Unlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.link_Unlogin.Location = new System.Drawing.Point(480, 373);
            this.link_Unlogin.Name = "link_Unlogin";
            this.link_Unlogin.Size = new System.Drawing.Size(106, 17);
            this.link_Unlogin.TabIndex = 2;
            this.link_Unlogin.TabStop = true;
            this.link_Unlogin.Text = "Разлогиниться";
            this.link_Unlogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Unlogin_LinkClicked);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 410);
            this.Controls.Add(this.link_Unlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sportsman);
            this.Controls.Add(this.btn_OwnEquipment);
            this.Controls.Add(this.btn_SportEquipment);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Firm);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор таблицы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Firm;
        private System.Windows.Forms.Button btn_SportEquipment;
        private System.Windows.Forms.Button btn_OwnEquipment;
        private System.Windows.Forms.Button btn_Sportsman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.LinkLabel link_Unlogin;
    }
}