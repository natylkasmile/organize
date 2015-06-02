namespace kurs
{
    partial class BD_Practice
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
            this.GV_BDPrac = new System.Windows.Forms.DataGridView();
            this.B_ADD_BDPrac = new System.Windows.Forms.Button();
            this.B_EDIT_BDPrac = new System.Windows.Forms.Button();
            this.B_DEL_BDPrac = new System.Windows.Forms.Button();
            this.TB_BDPrac_name = new System.Windows.Forms.TextBox();
            this.TB_BDPrac_Theme = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDPrac)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_BDPrac
            // 
            this.GV_BDPrac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BDPrac.Location = new System.Drawing.Point(4, 13);
            this.GV_BDPrac.Name = "GV_BDPrac";
            this.GV_BDPrac.Size = new System.Drawing.Size(240, 150);
            this.GV_BDPrac.TabIndex = 0;
            this.GV_BDPrac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_BDPrac_CellClick);
            // 
            // B_ADD_BDPrac
            // 
            this.B_ADD_BDPrac.Location = new System.Drawing.Point(12, 245);
            this.B_ADD_BDPrac.Name = "B_ADD_BDPrac";
            this.B_ADD_BDPrac.Size = new System.Drawing.Size(247, 23);
            this.B_ADD_BDPrac.TabIndex = 1;
            this.B_ADD_BDPrac.Text = "Добавить новое практическое задание";
            this.B_ADD_BDPrac.UseVisualStyleBackColor = true;
            this.B_ADD_BDPrac.Click += new System.EventHandler(this.B_ADD_BDPrac_Click);
            // 
            // B_EDIT_BDPrac
            // 
            this.B_EDIT_BDPrac.Location = new System.Drawing.Point(12, 274);
            this.B_EDIT_BDPrac.Name = "B_EDIT_BDPrac";
            this.B_EDIT_BDPrac.Size = new System.Drawing.Size(247, 23);
            this.B_EDIT_BDPrac.TabIndex = 2;
            this.B_EDIT_BDPrac.Text = "Редактировать выбранное задание";
            this.B_EDIT_BDPrac.UseVisualStyleBackColor = true;
            this.B_EDIT_BDPrac.Click += new System.EventHandler(this.B_EDIT_BDPrac_Click);
            // 
            // B_DEL_BDPrac
            // 
            this.B_DEL_BDPrac.Location = new System.Drawing.Point(12, 303);
            this.B_DEL_BDPrac.Name = "B_DEL_BDPrac";
            this.B_DEL_BDPrac.Size = new System.Drawing.Size(247, 23);
            this.B_DEL_BDPrac.TabIndex = 3;
            this.B_DEL_BDPrac.Text = "Удалить выбранное практическое задание";
            this.B_DEL_BDPrac.UseVisualStyleBackColor = true;
            this.B_DEL_BDPrac.Click += new System.EventHandler(this.B_DEL_BDPrac_Click);
            // 
            // TB_BDPrac_name
            // 
            this.TB_BDPrac_name.Location = new System.Drawing.Point(4, 191);
            this.TB_BDPrac_name.Name = "TB_BDPrac_name";
            this.TB_BDPrac_name.Size = new System.Drawing.Size(100, 20);
            this.TB_BDPrac_name.TabIndex = 4;
            // 
            // TB_BDPrac_Theme
            // 
            this.TB_BDPrac_Theme.Location = new System.Drawing.Point(144, 191);
            this.TB_BDPrac_Theme.Name = "TB_BDPrac_Theme";
            this.TB_BDPrac_Theme.Size = new System.Drawing.Size(100, 20);
            this.TB_BDPrac_Theme.TabIndex = 5;
            // 
            // BD_Practice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 338);
            this.Controls.Add(this.TB_BDPrac_Theme);
            this.Controls.Add(this.TB_BDPrac_name);
            this.Controls.Add(this.B_DEL_BDPrac);
            this.Controls.Add(this.B_EDIT_BDPrac);
            this.Controls.Add(this.B_ADD_BDPrac);
            this.Controls.Add(this.GV_BDPrac);
            this.Name = "BD_Practice";
            this.Text = "BD_Practice";
            this.Load += new System.EventHandler(this.BD_Practice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDPrac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_BDPrac;
        private System.Windows.Forms.Button B_ADD_BDPrac;
        private System.Windows.Forms.Button B_EDIT_BDPrac;
        private System.Windows.Forms.Button B_DEL_BDPrac;
        private System.Windows.Forms.TextBox TB_BDPrac_name;
        private System.Windows.Forms.TextBox TB_BDPrac_Theme;
    }
}