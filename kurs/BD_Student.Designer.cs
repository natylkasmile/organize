namespace kurs
{
    partial class BD_Student
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
            this.GV_BDSTUD = new System.Windows.Forms.DataGridView();
            this.B_ADD_BDStud = new System.Windows.Forms.Button();
            this.B_EDIT_BDStud = new System.Windows.Forms.Button();
            this.B_DEL_BDStud = new System.Windows.Forms.Button();
            this.TB_BDStud_name = new System.Windows.Forms.TextBox();
            this.TB_BDStud_mail = new System.Windows.Forms.TextBox();
            this.TB_BDStud_idgroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDSTUD)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_BDSTUD
            // 
            this.GV_BDSTUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BDSTUD.Location = new System.Drawing.Point(0, 0);
            this.GV_BDSTUD.Name = "GV_BDSTUD";
            this.GV_BDSTUD.Size = new System.Drawing.Size(275, 150);
            this.GV_BDSTUD.TabIndex = 0;
            this.GV_BDSTUD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_BDSTUD_CellClick);
            // 
            // B_ADD_BDStud
            // 
            this.B_ADD_BDStud.Location = new System.Drawing.Point(12, 229);
            this.B_ADD_BDStud.Name = "B_ADD_BDStud";
            this.B_ADD_BDStud.Size = new System.Drawing.Size(214, 23);
            this.B_ADD_BDStud.TabIndex = 1;
            this.B_ADD_BDStud.Text = "Добавить нового студента";
            this.B_ADD_BDStud.UseVisualStyleBackColor = true;
            this.B_ADD_BDStud.Click += new System.EventHandler(this.B_ADD_BDStud_Click);
            // 
            // B_EDIT_BDStud
            // 
            this.B_EDIT_BDStud.Location = new System.Drawing.Point(12, 258);
            this.B_EDIT_BDStud.Name = "B_EDIT_BDStud";
            this.B_EDIT_BDStud.Size = new System.Drawing.Size(214, 23);
            this.B_EDIT_BDStud.TabIndex = 2;
            this.B_EDIT_BDStud.Text = "Редактировать выбранного студента";
            this.B_EDIT_BDStud.UseVisualStyleBackColor = true;
            this.B_EDIT_BDStud.Click += new System.EventHandler(this.B_EDIT_BDStud_Click);
            // 
            // B_DEL_BDStud
            // 
            this.B_DEL_BDStud.Location = new System.Drawing.Point(12, 287);
            this.B_DEL_BDStud.Name = "B_DEL_BDStud";
            this.B_DEL_BDStud.Size = new System.Drawing.Size(214, 23);
            this.B_DEL_BDStud.TabIndex = 3;
            this.B_DEL_BDStud.Text = "Удалить выбранного студента";
            this.B_DEL_BDStud.UseVisualStyleBackColor = true;
            this.B_DEL_BDStud.Click += new System.EventHandler(this.B_DEL_BDStud_Click);
            // 
            // TB_BDStud_name
            // 
            this.TB_BDStud_name.Location = new System.Drawing.Point(10, 168);
            this.TB_BDStud_name.Name = "TB_BDStud_name";
            this.TB_BDStud_name.Size = new System.Drawing.Size(100, 20);
            this.TB_BDStud_name.TabIndex = 4;
            // 
            // TB_BDStud_mail
            // 
            this.TB_BDStud_mail.Location = new System.Drawing.Point(116, 168);
            this.TB_BDStud_mail.Name = "TB_BDStud_mail";
            this.TB_BDStud_mail.Size = new System.Drawing.Size(100, 20);
            this.TB_BDStud_mail.TabIndex = 5;
            this.TB_BDStud_mail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TB_BDStud_idgroup
            // 
            this.TB_BDStud_idgroup.Location = new System.Drawing.Point(222, 168);
            this.TB_BDStud_idgroup.Name = "TB_BDStud_idgroup";
            this.TB_BDStud_idgroup.Size = new System.Drawing.Size(53, 20);
            this.TB_BDStud_idgroup.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Группа";
            // 
            // BD_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_BDStud_idgroup);
            this.Controls.Add(this.TB_BDStud_mail);
            this.Controls.Add(this.TB_BDStud_name);
            this.Controls.Add(this.B_DEL_BDStud);
            this.Controls.Add(this.B_EDIT_BDStud);
            this.Controls.Add(this.B_ADD_BDStud);
            this.Controls.Add(this.GV_BDSTUD);
            this.Name = "BD_Student";
            this.Text = "BD_Student";
            this.Load += new System.EventHandler(this.BD_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDSTUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_BDSTUD;
        private System.Windows.Forms.Button B_ADD_BDStud;
        private System.Windows.Forms.Button B_EDIT_BDStud;
        private System.Windows.Forms.Button B_DEL_BDStud;
        private System.Windows.Forms.TextBox TB_BDStud_name;
        private System.Windows.Forms.TextBox TB_BDStud_mail;
        private System.Windows.Forms.TextBox TB_BDStud_idgroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}