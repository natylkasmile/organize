namespace kurs
{
    partial class BD_Theoria
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
            this.GV_BDTheor = new System.Windows.Forms.DataGridView();
            this.B_ADD_BDTheor = new System.Windows.Forms.Button();
            this.B_EDIT_BDTheor = new System.Windows.Forms.Button();
            this.B_DEL_BDTheor = new System.Windows.Forms.Button();
            this.TB_BDTheor_que = new System.Windows.Forms.TextBox();
            this.TB_BDTheor_them = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDTheor)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_BDTheor
            // 
            this.GV_BDTheor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BDTheor.Location = new System.Drawing.Point(13, 13);
            this.GV_BDTheor.Name = "GV_BDTheor";
            this.GV_BDTheor.Size = new System.Drawing.Size(240, 150);
            this.GV_BDTheor.TabIndex = 0;
            this.GV_BDTheor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_BDTheor_CellClick);
            // 
            // B_ADD_BDTheor
            // 
            this.B_ADD_BDTheor.Location = new System.Drawing.Point(12, 247);
            this.B_ADD_BDTheor.Name = "B_ADD_BDTheor";
            this.B_ADD_BDTheor.Size = new System.Drawing.Size(241, 23);
            this.B_ADD_BDTheor.TabIndex = 1;
            this.B_ADD_BDTheor.Text = "Добавить новый теоретический вопрос";
            this.B_ADD_BDTheor.UseVisualStyleBackColor = true;
            this.B_ADD_BDTheor.Click += new System.EventHandler(this.B_ADD_BDTheor_Click);
            // 
            // B_EDIT_BDTheor
            // 
            this.B_EDIT_BDTheor.Location = new System.Drawing.Point(13, 276);
            this.B_EDIT_BDTheor.Name = "B_EDIT_BDTheor";
            this.B_EDIT_BDTheor.Size = new System.Drawing.Size(240, 23);
            this.B_EDIT_BDTheor.TabIndex = 2;
            this.B_EDIT_BDTheor.Text = "Редактировать выбранный вопрос";
            this.B_EDIT_BDTheor.UseVisualStyleBackColor = true;
            this.B_EDIT_BDTheor.Click += new System.EventHandler(this.B_EDIT_BDTheor_Click);
            // 
            // B_DEL_BDTheor
            // 
            this.B_DEL_BDTheor.Location = new System.Drawing.Point(13, 305);
            this.B_DEL_BDTheor.Name = "B_DEL_BDTheor";
            this.B_DEL_BDTheor.Size = new System.Drawing.Size(240, 23);
            this.B_DEL_BDTheor.TabIndex = 3;
            this.B_DEL_BDTheor.Text = "Удалить выбранный вопрос";
            this.B_DEL_BDTheor.UseVisualStyleBackColor = true;
            this.B_DEL_BDTheor.Click += new System.EventHandler(this.B_DEL_BDTheor_Click);
            // 
            // TB_BDTheor_que
            // 
            this.TB_BDTheor_que.Location = new System.Drawing.Point(12, 182);
            this.TB_BDTheor_que.Name = "TB_BDTheor_que";
            this.TB_BDTheor_que.Size = new System.Drawing.Size(100, 20);
            this.TB_BDTheor_que.TabIndex = 4;
            // 
            // TB_BDTheor_them
            // 
            this.TB_BDTheor_them.Location = new System.Drawing.Point(153, 182);
            this.TB_BDTheor_them.Name = "TB_BDTheor_them";
            this.TB_BDTheor_them.Size = new System.Drawing.Size(100, 20);
            this.TB_BDTheor_them.TabIndex = 5;
            // 
            // BD_Theoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 340);
            this.Controls.Add(this.TB_BDTheor_them);
            this.Controls.Add(this.TB_BDTheor_que);
            this.Controls.Add(this.B_DEL_BDTheor);
            this.Controls.Add(this.B_EDIT_BDTheor);
            this.Controls.Add(this.B_ADD_BDTheor);
            this.Controls.Add(this.GV_BDTheor);
            this.Name = "BD_Theoria";
            this.Text = "Theoria";
            this.Load += new System.EventHandler(this.BD_Theoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDTheor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_BDTheor;
        private System.Windows.Forms.Button B_ADD_BDTheor;
        private System.Windows.Forms.Button B_EDIT_BDTheor;
        private System.Windows.Forms.Button B_DEL_BDTheor;
        private System.Windows.Forms.TextBox TB_BDTheor_que;
        private System.Windows.Forms.TextBox TB_BDTheor_them;
    }
}