namespace kurs
{
    partial class BD_Mark
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
            this.GV_BDMark = new System.Windows.Forms.DataGridView();
            this.B_ADD_BDMark = new System.Windows.Forms.Button();
            this.B_EDIT_BDMark = new System.Windows.Forms.Button();
            this.B_DEL_BDMark = new System.Windows.Forms.Button();
            this.TB_BDMark_point = new System.Windows.Forms.TextBox();
            this.TB_BDMark_date = new System.Windows.Forms.TextBox();
            this.TB_BDMark_les = new System.Windows.Forms.TextBox();
            this.TB_BDMark_Student = new System.Windows.Forms.TextBox();
            this.TB_BDMark_sub = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDMark)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_BDMark
            // 
            this.GV_BDMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BDMark.Location = new System.Drawing.Point(0, 0);
            this.GV_BDMark.Name = "GV_BDMark";
            this.GV_BDMark.Size = new System.Drawing.Size(403, 150);
            this.GV_BDMark.TabIndex = 0;
            this.GV_BDMark.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_BDMark_CellClick);
            // 
            // B_ADD_BDMark
            // 
            this.B_ADD_BDMark.Location = new System.Drawing.Point(25, 227);
            this.B_ADD_BDMark.Name = "B_ADD_BDMark";
            this.B_ADD_BDMark.Size = new System.Drawing.Size(198, 23);
            this.B_ADD_BDMark.TabIndex = 1;
            this.B_ADD_BDMark.Text = "Добавить новую ценку";
            this.B_ADD_BDMark.UseVisualStyleBackColor = true;
            this.B_ADD_BDMark.Click += new System.EventHandler(this.B_ADD_BDMark_Click);
            // 
            // B_EDIT_BDMark
            // 
            this.B_EDIT_BDMark.Location = new System.Drawing.Point(25, 256);
            this.B_EDIT_BDMark.Name = "B_EDIT_BDMark";
            this.B_EDIT_BDMark.Size = new System.Drawing.Size(198, 23);
            this.B_EDIT_BDMark.TabIndex = 2;
            this.B_EDIT_BDMark.Text = "Редактировать выбранную оценку";
            this.B_EDIT_BDMark.UseVisualStyleBackColor = true;
            this.B_EDIT_BDMark.Click += new System.EventHandler(this.B_EDIT_BDMark_Click);
            // 
            // B_DEL_BDMark
            // 
            this.B_DEL_BDMark.Location = new System.Drawing.Point(25, 285);
            this.B_DEL_BDMark.Name = "B_DEL_BDMark";
            this.B_DEL_BDMark.Size = new System.Drawing.Size(198, 23);
            this.B_DEL_BDMark.TabIndex = 3;
            this.B_DEL_BDMark.Text = "Удалить выбранную оценку";
            this.B_DEL_BDMark.UseVisualStyleBackColor = true;
            this.B_DEL_BDMark.Click += new System.EventHandler(this.B_DEL_BDMark_Click);
            // 
            // TB_BDMark_point
            // 
            this.TB_BDMark_point.Location = new System.Drawing.Point(53, 156);
            this.TB_BDMark_point.Name = "TB_BDMark_point";
            this.TB_BDMark_point.Size = new System.Drawing.Size(47, 20);
            this.TB_BDMark_point.TabIndex = 4;
            // 
            // TB_BDMark_date
            // 
            this.TB_BDMark_date.Location = new System.Drawing.Point(126, 156);
            this.TB_BDMark_date.Name = "TB_BDMark_date";
            this.TB_BDMark_date.Size = new System.Drawing.Size(46, 20);
            this.TB_BDMark_date.TabIndex = 5;
            // 
            // TB_BDMark_les
            // 
            this.TB_BDMark_les.Location = new System.Drawing.Point(187, 156);
            this.TB_BDMark_les.Name = "TB_BDMark_les";
            this.TB_BDMark_les.Size = new System.Drawing.Size(51, 20);
            this.TB_BDMark_les.TabIndex = 6;
            // 
            // TB_BDMark_Student
            // 
            this.TB_BDMark_Student.Location = new System.Drawing.Point(268, 156);
            this.TB_BDMark_Student.Name = "TB_BDMark_Student";
            this.TB_BDMark_Student.Size = new System.Drawing.Size(46, 20);
            this.TB_BDMark_Student.TabIndex = 7;
            // 
            // TB_BDMark_sub
            // 
            this.TB_BDMark_sub.Location = new System.Drawing.Point(342, 156);
            this.TB_BDMark_sub.Name = "TB_BDMark_sub";
            this.TB_BDMark_sub.Size = new System.Drawing.Size(61, 20);
            this.TB_BDMark_sub.TabIndex = 8;
            // 
            // BD_Mark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 320);
            this.Controls.Add(this.TB_BDMark_sub);
            this.Controls.Add(this.TB_BDMark_Student);
            this.Controls.Add(this.TB_BDMark_les);
            this.Controls.Add(this.TB_BDMark_date);
            this.Controls.Add(this.TB_BDMark_point);
            this.Controls.Add(this.B_DEL_BDMark);
            this.Controls.Add(this.B_EDIT_BDMark);
            this.Controls.Add(this.B_ADD_BDMark);
            this.Controls.Add(this.GV_BDMark);
            this.Name = "BD_Mark";
            this.Text = "BD_Mark";
            this.Load += new System.EventHandler(this.BD_Mark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_BDMark;
        private System.Windows.Forms.Button B_ADD_BDMark;
        private System.Windows.Forms.Button B_EDIT_BDMark;
        private System.Windows.Forms.Button B_DEL_BDMark;
        private System.Windows.Forms.TextBox TB_BDMark_point;
        private System.Windows.Forms.TextBox TB_BDMark_date;
        private System.Windows.Forms.TextBox TB_BDMark_les;
        private System.Windows.Forms.TextBox TB_BDMark_Student;
        private System.Windows.Forms.TextBox TB_BDMark_sub;
    }
}