namespace kurs
{
    partial class BD_T_Quest
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
            this.GV_BDTQuest = new System.Windows.Forms.DataGridView();
            this.B_ADD_BDTQuest = new System.Windows.Forms.Button();
            this.B_EDIT_BDTQuest = new System.Windows.Forms.Button();
            this.B_DEL_BDTQuest = new System.Windows.Forms.Button();
            this.TB_TQuest_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDTQuest)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_BDTQuest
            // 
            this.GV_BDTQuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BDTQuest.Location = new System.Drawing.Point(0, 0);
            this.GV_BDTQuest.Name = "GV_BDTQuest";
            this.GV_BDTQuest.Size = new System.Drawing.Size(240, 150);
            this.GV_BDTQuest.TabIndex = 0;
            this.GV_BDTQuest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_BDTQuest_CellClick);
            // 
            // B_ADD_BDTQuest
            // 
            this.B_ADD_BDTQuest.Location = new System.Drawing.Point(0, 190);
            this.B_ADD_BDTQuest.Name = "B_ADD_BDTQuest";
            this.B_ADD_BDTQuest.Size = new System.Drawing.Size(212, 23);
            this.B_ADD_BDTQuest.TabIndex = 1;
            this.B_ADD_BDTQuest.Text = "Добавить новый типовой вопрос";
            this.B_ADD_BDTQuest.UseVisualStyleBackColor = true;
            this.B_ADD_BDTQuest.Click += new System.EventHandler(this.B_ADD_BDTQuest_Click);
            // 
            // B_EDIT_BDTQuest
            // 
            this.B_EDIT_BDTQuest.Location = new System.Drawing.Point(0, 219);
            this.B_EDIT_BDTQuest.Name = "B_EDIT_BDTQuest";
            this.B_EDIT_BDTQuest.Size = new System.Drawing.Size(212, 23);
            this.B_EDIT_BDTQuest.TabIndex = 2;
            this.B_EDIT_BDTQuest.Text = "Редактировать выбранный вопрос";
            this.B_EDIT_BDTQuest.UseVisualStyleBackColor = true;
            this.B_EDIT_BDTQuest.Click += new System.EventHandler(this.B_EDIT_BDTQuest_Click);
            // 
            // B_DEL_BDTQuest
            // 
            this.B_DEL_BDTQuest.Location = new System.Drawing.Point(0, 248);
            this.B_DEL_BDTQuest.Name = "B_DEL_BDTQuest";
            this.B_DEL_BDTQuest.Size = new System.Drawing.Size(212, 23);
            this.B_DEL_BDTQuest.TabIndex = 3;
            this.B_DEL_BDTQuest.Text = "Удалить выбранный вопрос";
            this.B_DEL_BDTQuest.UseVisualStyleBackColor = true;
            this.B_DEL_BDTQuest.Click += new System.EventHandler(this.B_DEL_BDTQuest_Click);
            // 
            // TB_TQuest_name
            // 
            this.TB_TQuest_name.Location = new System.Drawing.Point(0, 156);
            this.TB_TQuest_name.Name = "TB_TQuest_name";
            this.TB_TQuest_name.Size = new System.Drawing.Size(100, 20);
            this.TB_TQuest_name.TabIndex = 4;
            // 
            // BD_T_Quest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 283);
            this.Controls.Add(this.TB_TQuest_name);
            this.Controls.Add(this.B_DEL_BDTQuest);
            this.Controls.Add(this.B_EDIT_BDTQuest);
            this.Controls.Add(this.B_ADD_BDTQuest);
            this.Controls.Add(this.GV_BDTQuest);
            this.Name = "BD_T_Quest";
            this.Text = "BD_T_Quest";
            this.Load += new System.EventHandler(this.BD_T_Quest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDTQuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_BDTQuest;
        private System.Windows.Forms.Button B_ADD_BDTQuest;
        private System.Windows.Forms.Button B_EDIT_BDTQuest;
        private System.Windows.Forms.Button B_DEL_BDTQuest;
        private System.Windows.Forms.TextBox TB_TQuest_name;
    }
}