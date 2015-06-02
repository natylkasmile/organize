namespace kurs
{
    partial class BD_Group_Sub
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
            this.GV_BDG_S = new System.Windows.Forms.DataGridView();
            this.B_ADD_BDG_S = new System.Windows.Forms.Button();
            this.B_EDIT_BDG_S = new System.Windows.Forms.Button();
            this.B_DEL_BDG_S = new System.Windows.Forms.Button();
            this.TB_BDG_S_gr = new System.Windows.Forms.TextBox();
            this.TB_BDG_S_sub = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDG_S)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_BDG_S
            // 
            this.GV_BDG_S.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BDG_S.Location = new System.Drawing.Point(2, 1);
            this.GV_BDG_S.Name = "GV_BDG_S";
            this.GV_BDG_S.Size = new System.Drawing.Size(240, 150);
            this.GV_BDG_S.TabIndex = 0;
            this.GV_BDG_S.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_BDG_S_CellClick);
            // 
            // B_ADD_BDG_S
            // 
            this.B_ADD_BDG_S.Location = new System.Drawing.Point(8, 236);
            this.B_ADD_BDG_S.Name = "B_ADD_BDG_S";
            this.B_ADD_BDG_S.Size = new System.Drawing.Size(264, 23);
            this.B_ADD_BDG_S.TabIndex = 1;
            this.B_ADD_BDG_S.Text = "Добавить новое отношение Группы и Предмета";
            this.B_ADD_BDG_S.UseVisualStyleBackColor = true;
            this.B_ADD_BDG_S.Click += new System.EventHandler(this.B_ADD_BDG_S_Click);
            // 
            // B_EDIT_BDG_S
            // 
            this.B_EDIT_BDG_S.Location = new System.Drawing.Point(8, 265);
            this.B_EDIT_BDG_S.Name = "B_EDIT_BDG_S";
            this.B_EDIT_BDG_S.Size = new System.Drawing.Size(264, 23);
            this.B_EDIT_BDG_S.TabIndex = 2;
            this.B_EDIT_BDG_S.Text = "Редактировать выбранное отношение";
            this.B_EDIT_BDG_S.UseVisualStyleBackColor = true;
            this.B_EDIT_BDG_S.Click += new System.EventHandler(this.B_EDIT_BDG_S_Click);
            // 
            // B_DEL_BDG_S
            // 
            this.B_DEL_BDG_S.Location = new System.Drawing.Point(8, 294);
            this.B_DEL_BDG_S.Name = "B_DEL_BDG_S";
            this.B_DEL_BDG_S.Size = new System.Drawing.Size(264, 23);
            this.B_DEL_BDG_S.TabIndex = 3;
            this.B_DEL_BDG_S.Text = "Удалить выбранное отношение";
            this.B_DEL_BDG_S.UseVisualStyleBackColor = true;
            this.B_DEL_BDG_S.Click += new System.EventHandler(this.B_DEL_BDG_S_Click);
            // 
            // TB_BDG_S_gr
            // 
            this.TB_BDG_S_gr.Location = new System.Drawing.Point(2, 173);
            this.TB_BDG_S_gr.Name = "TB_BDG_S_gr";
            this.TB_BDG_S_gr.Size = new System.Drawing.Size(100, 20);
            this.TB_BDG_S_gr.TabIndex = 4;
            // 
            // TB_BDG_S_sub
            // 
            this.TB_BDG_S_sub.Location = new System.Drawing.Point(142, 173);
            this.TB_BDG_S_sub.Name = "TB_BDG_S_sub";
            this.TB_BDG_S_sub.Size = new System.Drawing.Size(100, 20);
            this.TB_BDG_S_sub.TabIndex = 5;
            // 
            // BD_Group_Sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 329);
            this.Controls.Add(this.TB_BDG_S_sub);
            this.Controls.Add(this.TB_BDG_S_gr);
            this.Controls.Add(this.B_DEL_BDG_S);
            this.Controls.Add(this.B_EDIT_BDG_S);
            this.Controls.Add(this.B_ADD_BDG_S);
            this.Controls.Add(this.GV_BDG_S);
            this.Name = "BD_Group_Sub";
            this.Text = "BD_Group_Sub";
            this.Load += new System.EventHandler(this.BD_Group_Sub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDG_S)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_BDG_S;
        private System.Windows.Forms.Button B_ADD_BDG_S;
        private System.Windows.Forms.Button B_EDIT_BDG_S;
        private System.Windows.Forms.Button B_DEL_BDG_S;
        private System.Windows.Forms.TextBox TB_BDG_S_gr;
        private System.Windows.Forms.TextBox TB_BDG_S_sub;
    }
}