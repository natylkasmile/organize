namespace kurs
{
    partial class BD_Lessons
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
            this.GV_BDLES = new System.Windows.Forms.DataGridView();
            this.B_Add_BDLES = new System.Windows.Forms.Button();
            this.B_EDIT_BDLES = new System.Windows.Forms.Button();
            this.B_DEL_BDLES = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDLES)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_BDLES
            // 
            this.GV_BDLES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_BDLES.Location = new System.Drawing.Point(13, 13);
            this.GV_BDLES.Name = "GV_BDLES";
            this.GV_BDLES.Size = new System.Drawing.Size(240, 150);
            this.GV_BDLES.TabIndex = 0;
            this.GV_BDLES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GV_BDLES_CellContentClick);
            this.GV_BDLES.Click += new System.EventHandler(this.GV_BDLES_Click);
            // 
            // B_Add_BDLES
            // 
            this.B_Add_BDLES.Location = new System.Drawing.Point(13, 198);
            this.B_Add_BDLES.Name = "B_Add_BDLES";
            this.B_Add_BDLES.Size = new System.Drawing.Size(221, 23);
            this.B_Add_BDLES.TabIndex = 1;
            this.B_Add_BDLES.Text = "Добоавить новый тип занятий";
            this.B_Add_BDLES.UseVisualStyleBackColor = true;
            this.B_Add_BDLES.Click += new System.EventHandler(this.B_Add_BDLES_Click);
            // 
            // B_EDIT_BDLES
            // 
            this.B_EDIT_BDLES.Location = new System.Drawing.Point(12, 227);
            this.B_EDIT_BDLES.Name = "B_EDIT_BDLES";
            this.B_EDIT_BDLES.Size = new System.Drawing.Size(222, 23);
            this.B_EDIT_BDLES.TabIndex = 2;
            this.B_EDIT_BDLES.Text = "Редактировать выбранный тип занятий";
            this.B_EDIT_BDLES.UseVisualStyleBackColor = true;
            this.B_EDIT_BDLES.Click += new System.EventHandler(this.B_EDIT_BDLES_Click);
            // 
            // B_DEL_BDLES
            // 
            this.B_DEL_BDLES.Location = new System.Drawing.Point(12, 256);
            this.B_DEL_BDLES.Name = "B_DEL_BDLES";
            this.B_DEL_BDLES.Size = new System.Drawing.Size(222, 23);
            this.B_DEL_BDLES.TabIndex = 3;
            this.B_DEL_BDLES.Text = "Удалить выбранный тип занятий";
            this.B_DEL_BDLES.UseVisualStyleBackColor = true;
            this.B_DEL_BDLES.Click += new System.EventHandler(this.B_DEL_BDLES_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // BD_Lessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 320);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.B_DEL_BDLES);
            this.Controls.Add(this.B_EDIT_BDLES);
            this.Controls.Add(this.B_Add_BDLES);
            this.Controls.Add(this.GV_BDLES);
            this.Name = "BD_Lessons";
            this.Text = "BD_Lessons";
            this.Load += new System.EventHandler(this.BD_Lessons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_BDLES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_BDLES;
        private System.Windows.Forms.Button B_Add_BDLES;
        private System.Windows.Forms.Button B_EDIT_BDLES;
        private System.Windows.Forms.Button B_DEL_BDLES;
        private System.Windows.Forms.TextBox textBox1;
    }
}