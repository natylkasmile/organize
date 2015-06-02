namespace kurs
{
    partial class BD_T_Answ
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
            this.GV_BDTansw = new System.Windows.Forms.DataGridView();
            this.B_ADD_BDtansw = new System.Windows.Forms.Button();
            this.B_EDIT_BDtansw = new System.Windows.Forms.Button();
            this.B_DEL_BDtansw = new System.Windows.Forms.Button();
            this.TB_BDTansw_ans = new System.Windows.Forms.TextBox();
            this.TB_BDTansw_ques = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDTansw)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_BDTansw
            // 
            this.GV_BDTansw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BDTansw.Location = new System.Drawing.Point(0, 0);
            this.GV_BDTansw.Name = "GV_BDTansw";
            this.GV_BDTansw.Size = new System.Drawing.Size(240, 150);
            this.GV_BDTansw.TabIndex = 0;
            this.GV_BDTansw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_BDTansw_CellClick);
            // 
            // B_ADD_BDtansw
            // 
            this.B_ADD_BDtansw.Location = new System.Drawing.Point(8, 261);
            this.B_ADD_BDtansw.Name = "B_ADD_BDtansw";
            this.B_ADD_BDtansw.Size = new System.Drawing.Size(232, 23);
            this.B_ADD_BDtansw.TabIndex = 1;
            this.B_ADD_BDtansw.Text = "Добавить новый типовой ответ";
            this.B_ADD_BDtansw.UseVisualStyleBackColor = true;
            this.B_ADD_BDtansw.Click += new System.EventHandler(this.B_ADD_BDtansw_Click);
            // 
            // B_EDIT_BDtansw
            // 
            this.B_EDIT_BDtansw.Location = new System.Drawing.Point(8, 290);
            this.B_EDIT_BDtansw.Name = "B_EDIT_BDtansw";
            this.B_EDIT_BDtansw.Size = new System.Drawing.Size(232, 23);
            this.B_EDIT_BDtansw.TabIndex = 2;
            this.B_EDIT_BDtansw.Text = "Редактировать выбранный ответ";
            this.B_EDIT_BDtansw.UseVisualStyleBackColor = true;
            this.B_EDIT_BDtansw.Click += new System.EventHandler(this.B_EDIT_BDtansw_Click);
            // 
            // B_DEL_BDtansw
            // 
            this.B_DEL_BDtansw.Location = new System.Drawing.Point(8, 319);
            this.B_DEL_BDtansw.Name = "B_DEL_BDtansw";
            this.B_DEL_BDtansw.Size = new System.Drawing.Size(232, 23);
            this.B_DEL_BDtansw.TabIndex = 3;
            this.B_DEL_BDtansw.Text = "Удалить выбранный ответ";
            this.B_DEL_BDtansw.UseVisualStyleBackColor = true;
            this.B_DEL_BDtansw.Click += new System.EventHandler(this.B_DEL_BDtansw_Click);
            // 
            // TB_BDTansw_ans
            // 
            this.TB_BDTansw_ans.Location = new System.Drawing.Point(8, 156);
            this.TB_BDTansw_ans.Name = "TB_BDTansw_ans";
            this.TB_BDTansw_ans.Size = new System.Drawing.Size(100, 20);
            this.TB_BDTansw_ans.TabIndex = 4;
            // 
            // TB_BDTansw_ques
            // 
            this.TB_BDTansw_ques.Location = new System.Drawing.Point(151, 156);
            this.TB_BDTansw_ques.Name = "TB_BDTansw_ques";
            this.TB_BDTansw_ques.Size = new System.Drawing.Size(100, 20);
            this.TB_BDTansw_ques.TabIndex = 5;
            // 
            // BD_T_Answ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 354);
            this.Controls.Add(this.TB_BDTansw_ques);
            this.Controls.Add(this.TB_BDTansw_ans);
            this.Controls.Add(this.B_DEL_BDtansw);
            this.Controls.Add(this.B_EDIT_BDtansw);
            this.Controls.Add(this.B_ADD_BDtansw);
            this.Controls.Add(this.GV_BDTansw);
            this.Name = "BD_T_Answ";
            this.Text = "BD_T_Answ";
            this.Load += new System.EventHandler(this.BD_T_Answ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDTansw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_BDTansw;
        private System.Windows.Forms.Button B_ADD_BDtansw;
        private System.Windows.Forms.Button B_EDIT_BDtansw;
        private System.Windows.Forms.Button B_DEL_BDtansw;
        private System.Windows.Forms.TextBox TB_BDTansw_ans;
        private System.Windows.Forms.TextBox TB_BDTansw_ques;
    }
}