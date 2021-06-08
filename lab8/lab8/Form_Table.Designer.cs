namespace lab8
{
    partial class Form_Table
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl_Value = new System.Windows.Forms.Label();
            this.cb_Column = new System.Windows.Forms.ComboBox();
            this.cb_Value = new System.Windows.Forms.ComboBox();
            this.btn_Drop = new System.Windows.Forms.Button();
            this.lbl_equal = new System.Windows.Forms.Label();
            this.lbl_Column = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv.Location = new System.Drawing.Point(12, 255);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(507, 234);
            this.dgv.TabIndex = 0;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.Location = new System.Drawing.Point(21, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(46, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "label1";
            // 
            // lbl_Value
            // 
            this.lbl_Value.AutoSize = true;
            this.lbl_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Value.Location = new System.Drawing.Point(272, 191);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(73, 17);
            this.lbl_Value.TabIndex = 1;
            this.lbl_Value.Text = "Значение";
            // 
            // cb_Column
            // 
            this.cb_Column.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Column.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Column.FormattingEnabled = true;
            this.cb_Column.Location = new System.Drawing.Point(12, 213);
            this.cb_Column.Name = "cb_Column";
            this.cb_Column.Size = new System.Drawing.Size(175, 25);
            this.cb_Column.TabIndex = 2;
            this.cb_Column.SelectedIndexChanged += new System.EventHandler(this.cb_Column_SelectedIndexChanged);
            // 
            // cb_Value
            // 
            this.cb_Value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Value.FormattingEnabled = true;
            this.cb_Value.Location = new System.Drawing.Point(223, 213);
            this.cb_Value.Name = "cb_Value";
            this.cb_Value.Size = new System.Drawing.Size(175, 25);
            this.cb_Value.TabIndex = 3;
            this.cb_Value.SelectedIndexChanged += new System.EventHandler(this.cb_Value_SelectedIndexChanged);
            // 
            // btn_Drop
            // 
            this.btn_Drop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Drop.Location = new System.Drawing.Point(417, 204);
            this.btn_Drop.Name = "btn_Drop";
            this.btn_Drop.Size = new System.Drawing.Size(102, 34);
            this.btn_Drop.TabIndex = 4;
            this.btn_Drop.Text = "Сбросить";
            this.btn_Drop.UseVisualStyleBackColor = true;
            this.btn_Drop.Click += new System.EventHandler(this.btn_Drop_Click);
            // 
            // lbl_equal
            // 
            this.lbl_equal.AutoSize = true;
            this.lbl_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_equal.Location = new System.Drawing.Point(193, 213);
            this.lbl_equal.Name = "lbl_equal";
            this.lbl_equal.Size = new System.Drawing.Size(24, 25);
            this.lbl_equal.TabIndex = 5;
            this.lbl_equal.Text = "=";
            // 
            // lbl_Column
            // 
            this.lbl_Column.AutoSize = true;
            this.lbl_Column.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Column.Location = new System.Drawing.Point(65, 191);
            this.lbl_Column.Name = "lbl_Column";
            this.lbl_Column.Size = new System.Drawing.Size(64, 17);
            this.lbl_Column.TabIndex = 1;
            this.lbl_Column.Text = "Столбец";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2.Location = new System.Drawing.Point(21, 59);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(46, 17);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "label2";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add.Location = new System.Drawing.Point(417, 15);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(102, 34);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Update.Location = new System.Drawing.Point(417, 65);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(102, 34);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Обновить";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Delete.Location = new System.Drawing.Point(417, 114);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(102, 34);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Удалить";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Form_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 500);
            this.Controls.Add(this.lbl_equal);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Drop);
            this.Controls.Add(this.cb_Value);
            this.Controls.Add(this.cb_Column);
            this.Controls.Add(this.lbl_Column);
            this.Controls.Add(this.lbl_Value);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgv);
            this.Name = "Form_Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Table";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_Value;
        private System.Windows.Forms.ComboBox cb_Column;
        private System.Windows.Forms.ComboBox cb_Value;
        private System.Windows.Forms.Button btn_Drop;
        private System.Windows.Forms.Label lbl_equal;
        private System.Windows.Forms.Label lbl_Column;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
    }
}