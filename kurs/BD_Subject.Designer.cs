namespace kurs
{
    partial class BD_Subject
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
            this.GV_BDSub = new System.Windows.Forms.DataGridView();
            this.B_ADD_BDSub = new System.Windows.Forms.Button();
            this.B_EDIT_BDSub = new System.Windows.Forms.Button();
            this.B_DEL_BDSub = new System.Windows.Forms.Button();
            this.TB_BDSub_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDSub)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_BDSub
            // 
            this.GV_BDSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BDSub.Location = new System.Drawing.Point(0, 0);
            this.GV_BDSub.Name = "GV_BDSub";
            this.GV_BDSub.Size = new System.Drawing.Size(240, 150);
            this.GV_BDSub.TabIndex = 0;
            this.GV_BDSub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_BDSub_CellClick);
            // 
            // B_ADD_BDSub
            // 
            this.B_ADD_BDSub.Location = new System.Drawing.Point(8, 201);
            this.B_ADD_BDSub.Name = "B_ADD_BDSub";
            this.B_ADD_BDSub.Size = new System.Drawing.Size(214, 23);
            this.B_ADD_BDSub.TabIndex = 1;
            this.B_ADD_BDSub.Text = "Добавить новый предмет";
            this.B_ADD_BDSub.UseVisualStyleBackColor = true;
            this.B_ADD_BDSub.Click += new System.EventHandler(this.B_ADD_BDSub_Click);
            // 
            // B_EDIT_BDSub
            // 
            this.B_EDIT_BDSub.Location = new System.Drawing.Point(8, 230);
            this.B_EDIT_BDSub.Name = "B_EDIT_BDSub";
            this.B_EDIT_BDSub.Size = new System.Drawing.Size(214, 23);
            this.B_EDIT_BDSub.TabIndex = 2;
            this.B_EDIT_BDSub.Text = "Редактировать выбранный предмет";
            this.B_EDIT_BDSub.UseVisualStyleBackColor = true;
            this.B_EDIT_BDSub.Click += new System.EventHandler(this.B_EDIT_BDSub_Click);
            // 
            // B_DEL_BDSub
            // 
            this.B_DEL_BDSub.Location = new System.Drawing.Point(8, 259);
            this.B_DEL_BDSub.Name = "B_DEL_BDSub";
            this.B_DEL_BDSub.Size = new System.Drawing.Size(214, 23);
            this.B_DEL_BDSub.TabIndex = 3;
            this.B_DEL_BDSub.Text = "Удалить Выбранный предмет";
            this.B_DEL_BDSub.UseVisualStyleBackColor = true;
            this.B_DEL_BDSub.Click += new System.EventHandler(this.B_DEL_BDSub_Click);
            // 
            // TB_BDSub_name
            // 
            this.TB_BDSub_name.Location = new System.Drawing.Point(8, 175);
            this.TB_BDSub_name.Name = "TB_BDSub_name";
            this.TB_BDSub_name.Size = new System.Drawing.Size(100, 20);
            this.TB_BDSub_name.TabIndex = 4;
            // 
            // BD_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 294);
            this.Controls.Add(this.TB_BDSub_name);
            this.Controls.Add(this.B_DEL_BDSub);
            this.Controls.Add(this.B_EDIT_BDSub);
            this.Controls.Add(this.B_ADD_BDSub);
            this.Controls.Add(this.GV_BDSub);
            this.Name = "BD_Subject";
            this.Text = "BD_Subject";
            this.Load += new System.EventHandler(this.BD_Subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_BDSub;
        private System.Windows.Forms.Button B_ADD_BDSub;
        private System.Windows.Forms.Button B_EDIT_BDSub;
        private System.Windows.Forms.Button B_DEL_BDSub;
        private System.Windows.Forms.TextBox TB_BDSub_name;
    }
}