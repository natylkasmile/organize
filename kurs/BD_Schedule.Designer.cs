namespace kurs
{
    partial class BD_Schedule
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
            this.GV_BDSched = new System.Windows.Forms.DataGridView();
            this.B_Add_BDSched = new System.Windows.Forms.Button();
            this.B_EDIT_BDSched = new System.Windows.Forms.Button();
            this.B_DEL_BDSched = new System.Windows.Forms.Button();
            this.TB_BDSched_day = new System.Windows.Forms.TextBox();
            this.TB_BDSched_pair = new System.Windows.Forms.TextBox();
            this.TB_BDSched_les = new System.Windows.Forms.TextBox();
            this.TB_BDSched_rel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDSched)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_BDSched
            // 
            this.GV_BDSched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BDSched.Location = new System.Drawing.Point(0, 0);
            this.GV_BDSched.Name = "GV_BDSched";
            this.GV_BDSched.Size = new System.Drawing.Size(441, 150);
            this.GV_BDSched.TabIndex = 0;
            this.GV_BDSched.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_BDSched_CellClick);
            // 
            // B_Add_BDSched
            // 
            this.B_Add_BDSched.Location = new System.Drawing.Point(16, 230);
            this.B_Add_BDSched.Name = "B_Add_BDSched";
            this.B_Add_BDSched.Size = new System.Drawing.Size(264, 23);
            this.B_Add_BDSched.TabIndex = 1;
            this.B_Add_BDSched.Text = "Добавить новые данные в расписание";
            this.B_Add_BDSched.UseVisualStyleBackColor = true;
            this.B_Add_BDSched.Click += new System.EventHandler(this.B_Add_BDSched_Click);
            // 
            // B_EDIT_BDSched
            // 
            this.B_EDIT_BDSched.Location = new System.Drawing.Point(16, 259);
            this.B_EDIT_BDSched.Name = "B_EDIT_BDSched";
            this.B_EDIT_BDSched.Size = new System.Drawing.Size(264, 23);
            this.B_EDIT_BDSched.TabIndex = 2;
            this.B_EDIT_BDSched.Text = "Редактировать выбранный элемент расписания";
            this.B_EDIT_BDSched.UseVisualStyleBackColor = true;
            this.B_EDIT_BDSched.Click += new System.EventHandler(this.B_EDIT_BDSched_Click);
            // 
            // B_DEL_BDSched
            // 
            this.B_DEL_BDSched.Location = new System.Drawing.Point(16, 288);
            this.B_DEL_BDSched.Name = "B_DEL_BDSched";
            this.B_DEL_BDSched.Size = new System.Drawing.Size(264, 23);
            this.B_DEL_BDSched.TabIndex = 3;
            this.B_DEL_BDSched.Text = "Удалить выбранный элемент";
            this.B_DEL_BDSched.UseVisualStyleBackColor = true;
            this.B_DEL_BDSched.Click += new System.EventHandler(this.B_DEL_BDSched_Click);
            // 
            // TB_BDSched_day
            // 
            this.TB_BDSched_day.Location = new System.Drawing.Point(16, 187);
            this.TB_BDSched_day.Name = "TB_BDSched_day";
            this.TB_BDSched_day.Size = new System.Drawing.Size(54, 20);
            this.TB_BDSched_day.TabIndex = 4;
            // 
            // TB_BDSched_pair
            // 
            this.TB_BDSched_pair.Location = new System.Drawing.Point(89, 187);
            this.TB_BDSched_pair.Name = "TB_BDSched_pair";
            this.TB_BDSched_pair.Size = new System.Drawing.Size(51, 20);
            this.TB_BDSched_pair.TabIndex = 5;
            // 
            // TB_BDSched_les
            // 
            this.TB_BDSched_les.Location = new System.Drawing.Point(159, 187);
            this.TB_BDSched_les.Name = "TB_BDSched_les";
            this.TB_BDSched_les.Size = new System.Drawing.Size(46, 20);
            this.TB_BDSched_les.TabIndex = 6;
            // 
            // TB_BDSched_rel
            // 
            this.TB_BDSched_rel.Location = new System.Drawing.Point(223, 187);
            this.TB_BDSched_rel.Name = "TB_BDSched_rel";
            this.TB_BDSched_rel.Size = new System.Drawing.Size(57, 20);
            this.TB_BDSched_rel.TabIndex = 7;
            // 
            // BD_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 323);
            this.Controls.Add(this.TB_BDSched_rel);
            this.Controls.Add(this.TB_BDSched_les);
            this.Controls.Add(this.TB_BDSched_pair);
            this.Controls.Add(this.TB_BDSched_day);
            this.Controls.Add(this.B_DEL_BDSched);
            this.Controls.Add(this.B_EDIT_BDSched);
            this.Controls.Add(this.B_Add_BDSched);
            this.Controls.Add(this.GV_BDSched);
            this.Name = "BD_Schedule";
            this.Text = "BD_Schedule";
            this.Load += new System.EventHandler(this.BD_Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDSched)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_BDSched;
        private System.Windows.Forms.Button B_Add_BDSched;
        private System.Windows.Forms.Button B_EDIT_BDSched;
        private System.Windows.Forms.Button B_DEL_BDSched;
        private System.Windows.Forms.TextBox TB_BDSched_day;
        private System.Windows.Forms.TextBox TB_BDSched_pair;
        private System.Windows.Forms.TextBox TB_BDSched_les;
        private System.Windows.Forms.TextBox TB_BDSched_rel;
    }
}