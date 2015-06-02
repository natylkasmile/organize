namespace kurs
{
    partial class BD_Add_Stud
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
            this.B_ADD_ST = new System.Windows.Forms.Button();
            this.TB_BDStud_mail = new System.Windows.Forms.TextBox();
            this.TB_BDStud_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_BDStud_group = new System.Windows.Forms.TextBox();
            this.GV_BD_ST_GR = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BD_ST_GR)).BeginInit();
            this.SuspendLayout();
            // 
            // B_ADD_ST
            // 
            this.B_ADD_ST.Location = new System.Drawing.Point(164, 117);
            this.B_ADD_ST.Name = "B_ADD_ST";
            this.B_ADD_ST.Size = new System.Drawing.Size(75, 23);
            this.B_ADD_ST.TabIndex = 0;
            this.B_ADD_ST.Text = "Добавить";
            this.B_ADD_ST.UseVisualStyleBackColor = true;
            this.B_ADD_ST.Click += new System.EventHandler(this.B_ADD_ST_Click);
            // 
            // TB_BDStud_mail
            // 
            this.TB_BDStud_mail.Location = new System.Drawing.Point(139, 54);
            this.TB_BDStud_mail.Name = "TB_BDStud_mail";
            this.TB_BDStud_mail.Size = new System.Drawing.Size(100, 20);
            this.TB_BDStud_mail.TabIndex = 1;
            // 
            // TB_BDStud_name
            // 
            this.TB_BDStud_name.Location = new System.Drawing.Point(139, 28);
            this.TB_BDStud_name.Name = "TB_BDStud_name";
            this.TB_BDStud_name.Size = new System.Drawing.Size(100, 20);
            this.TB_BDStud_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Группа";
            // 
            // TB_BDStud_group
            // 
            this.TB_BDStud_group.Location = new System.Drawing.Point(139, 80);
            this.TB_BDStud_group.Name = "TB_BDStud_group";
            this.TB_BDStud_group.Size = new System.Drawing.Size(100, 20);
            this.TB_BDStud_group.TabIndex = 6;
            this.TB_BDStud_group.Click += new System.EventHandler(this.TB_BDStud_group_Click);
            // 
            // GV_BD_ST_GR
            // 
            this.GV_BD_ST_GR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BD_ST_GR.Location = new System.Drawing.Point(-1, 146);
            this.GV_BD_ST_GR.Name = "GV_BD_ST_GR";
            this.GV_BD_ST_GR.Size = new System.Drawing.Size(240, 143);
            this.GV_BD_ST_GR.TabIndex = 7;
            // 
            // BD_Add_Stud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 301);
            this.Controls.Add(this.GV_BD_ST_GR);
            this.Controls.Add(this.TB_BDStud_group);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_BDStud_name);
            this.Controls.Add(this.TB_BDStud_mail);
            this.Controls.Add(this.B_ADD_ST);
            this.Name = "BD_Add_Stud";
            this.Text = "BD_Add_Stud";
            this.Load += new System.EventHandler(this.BD_Add_Stud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_BD_ST_GR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_ADD_ST;
        private System.Windows.Forms.TextBox TB_BDStud_mail;
        private System.Windows.Forms.TextBox TB_BDStud_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_BDStud_group;
        private System.Windows.Forms.DataGridView GV_BD_ST_GR;
    }
}