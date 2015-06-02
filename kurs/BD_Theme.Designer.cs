namespace kurs
{
    partial class BD_Theme
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
            this.GV_BDTheme = new System.Windows.Forms.DataGridView();
            this.B_ADD_BDTheme = new System.Windows.Forms.Button();
            this.B_EDIT_BDTheme = new System.Windows.Forms.Button();
            this.B_DEL_BDTheme = new System.Windows.Forms.Button();
            this.TB_BDTheme_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_BDTheme
            // 
            this.GV_BDTheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BDTheme.Location = new System.Drawing.Point(0, 0);
            this.GV_BDTheme.Name = "GV_BDTheme";
            this.GV_BDTheme.Size = new System.Drawing.Size(240, 150);
            this.GV_BDTheme.TabIndex = 0;
            this.GV_BDTheme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_BDTheme_CellClick);
            // 
            // B_ADD_BDTheme
            // 
            this.B_ADD_BDTheme.Location = new System.Drawing.Point(12, 239);
            this.B_ADD_BDTheme.Name = "B_ADD_BDTheme";
            this.B_ADD_BDTheme.Size = new System.Drawing.Size(189, 23);
            this.B_ADD_BDTheme.TabIndex = 1;
            this.B_ADD_BDTheme.Text = "Добавить новую тему";
            this.B_ADD_BDTheme.UseVisualStyleBackColor = true;
            this.B_ADD_BDTheme.Click += new System.EventHandler(this.B_ADD_BDTheme_Click);
            // 
            // B_EDIT_BDTheme
            // 
            this.B_EDIT_BDTheme.Location = new System.Drawing.Point(12, 268);
            this.B_EDIT_BDTheme.Name = "B_EDIT_BDTheme";
            this.B_EDIT_BDTheme.Size = new System.Drawing.Size(189, 23);
            this.B_EDIT_BDTheme.TabIndex = 2;
            this.B_EDIT_BDTheme.Text = "Редактировать выбранную тему";
            this.B_EDIT_BDTheme.UseVisualStyleBackColor = true;
            this.B_EDIT_BDTheme.Click += new System.EventHandler(this.B_EDIT_BDTheme_Click);
            // 
            // B_DEL_BDTheme
            // 
            this.B_DEL_BDTheme.Location = new System.Drawing.Point(12, 297);
            this.B_DEL_BDTheme.Name = "B_DEL_BDTheme";
            this.B_DEL_BDTheme.Size = new System.Drawing.Size(189, 23);
            this.B_DEL_BDTheme.TabIndex = 3;
            this.B_DEL_BDTheme.Text = "Удалить выбранную тему";
            this.B_DEL_BDTheme.UseVisualStyleBackColor = true;
            this.B_DEL_BDTheme.Click += new System.EventHandler(this.B_DEL_BDTheme_Click);
            // 
            // TB_BDTheme_name
            // 
            this.TB_BDTheme_name.Location = new System.Drawing.Point(8, 169);
            this.TB_BDTheme_name.Name = "TB_BDTheme_name";
            this.TB_BDTheme_name.Size = new System.Drawing.Size(100, 20);
            this.TB_BDTheme_name.TabIndex = 4;
            // 
            // BD_Theme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 356);
            this.Controls.Add(this.TB_BDTheme_name);
            this.Controls.Add(this.B_DEL_BDTheme);
            this.Controls.Add(this.B_EDIT_BDTheme);
            this.Controls.Add(this.B_ADD_BDTheme);
            this.Controls.Add(this.GV_BDTheme);
            this.Name = "BD_Theme";
            this.Text = "BD_Theme";
            this.Load += new System.EventHandler(this.BD_Theme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDTheme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_BDTheme;
        private System.Windows.Forms.Button B_ADD_BDTheme;
        private System.Windows.Forms.Button B_EDIT_BDTheme;
        private System.Windows.Forms.Button B_DEL_BDTheme;
        private System.Windows.Forms.TextBox TB_BDTheme_name;
    }
}