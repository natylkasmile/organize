namespace kurs
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Choose_BD = new System.Windows.Forms.ToolStripSplitButton();
            this.bDStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_bDGroup = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Choose_BD});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Choose_BD
            // 
            this.Choose_BD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Choose_BD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bDStudentToolStripMenuItem,
            this.TS_bDGroup});
            this.Choose_BD.Image = ((System.Drawing.Image)(resources.GetObject("Choose_BD.Image")));
            this.Choose_BD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Choose_BD.Name = "Choose_BD";
            this.Choose_BD.Size = new System.Drawing.Size(32, 22);
            this.Choose_BD.Text = "Choose_BD";
            // 
            // bDStudentToolStripMenuItem
            // 
            this.bDStudentToolStripMenuItem.Name = "bDStudentToolStripMenuItem";
            this.bDStudentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bDStudentToolStripMenuItem.Text = "BD_Student";
            // 
            // TS_bDGroup
            // 
            this.TS_bDGroup.Name = "TS_bDGroup";
            this.TS_bDGroup.Size = new System.Drawing.Size(152, 22);
            this.TS_bDGroup.Text = "BD_Group";
            this.TS_bDGroup.Click += new System.EventHandler(this.TS_bDGroup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "F";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton Choose_BD;
        private System.Windows.Forms.ToolStripMenuItem bDStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TS_bDGroup;
    }
}

