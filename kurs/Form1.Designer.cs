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
            this.TS_bDStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_bDGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_bDLessons = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_bDSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_bDTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_bDGroupSub = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_bDPractice = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_bDTheoria = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_bDMark = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_bDSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_bDTranslate = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_bDTypeQuest = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_bDTypeAnsw = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.TS_Prigress = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 207);
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
            this.Choose_BD,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(276, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Choose_BD
            // 
            this.Choose_BD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Choose_BD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_bDStudent,
            this.TS_bDGroup,
            this.TS_bDLessons,
            this.TS_bDSubject,
            this.TS_bDTheme,
            this.TS_bDGroupSub,
            this.TS_bDPractice,
            this.TS_bDTheoria,
            this.TS_bDMark,
            this.TS_bDSchedule,
            this.TS_bDTranslate,
            this.TS_bDTypeQuest,
            this.TS_bDTypeAnsw});
            this.Choose_BD.Image = ((System.Drawing.Image)(resources.GetObject("Choose_BD.Image")));
            this.Choose_BD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Choose_BD.Name = "Choose_BD";
            this.Choose_BD.Size = new System.Drawing.Size(32, 22);
            this.Choose_BD.Text = "Choose_BD";
            // 
            // TS_bDStudent
            // 
            this.TS_bDStudent.Name = "TS_bDStudent";
            this.TS_bDStudent.Size = new System.Drawing.Size(152, 22);
            this.TS_bDStudent.Text = "BD_Student";
            this.TS_bDStudent.Click += new System.EventHandler(this.TS_bDStudent_Click);
            // 
            // TS_bDGroup
            // 
            this.TS_bDGroup.Name = "TS_bDGroup";
            this.TS_bDGroup.Size = new System.Drawing.Size(152, 22);
            this.TS_bDGroup.Text = "BD_Group";
            this.TS_bDGroup.Click += new System.EventHandler(this.TS_bDGroup_Click);
            // 
            // TS_bDLessons
            // 
            this.TS_bDLessons.Name = "TS_bDLessons";
            this.TS_bDLessons.Size = new System.Drawing.Size(152, 22);
            this.TS_bDLessons.Text = "BD_Lessons";
            this.TS_bDLessons.Click += new System.EventHandler(this.TS_bDLessons_Click);
            // 
            // TS_bDSubject
            // 
            this.TS_bDSubject.Name = "TS_bDSubject";
            this.TS_bDSubject.Size = new System.Drawing.Size(152, 22);
            this.TS_bDSubject.Text = "BD_Subject";
            this.TS_bDSubject.Click += new System.EventHandler(this.TS_bDSubject_Click);
            // 
            // TS_bDTheme
            // 
            this.TS_bDTheme.Name = "TS_bDTheme";
            this.TS_bDTheme.Size = new System.Drawing.Size(152, 22);
            this.TS_bDTheme.Text = "BD_Theme";
            this.TS_bDTheme.Click += new System.EventHandler(this.TS_bDTheme_Click);
            // 
            // TS_bDGroupSub
            // 
            this.TS_bDGroupSub.Name = "TS_bDGroupSub";
            this.TS_bDGroupSub.Size = new System.Drawing.Size(152, 22);
            this.TS_bDGroupSub.Text = "BD_Group_Sub";
            this.TS_bDGroupSub.Click += new System.EventHandler(this.TS_bDGroupSub_Click);
            // 
            // TS_bDPractice
            // 
            this.TS_bDPractice.Name = "TS_bDPractice";
            this.TS_bDPractice.Size = new System.Drawing.Size(152, 22);
            this.TS_bDPractice.Text = "BD_Practice";
            this.TS_bDPractice.Click += new System.EventHandler(this.TS_bDPractice_Click);
            // 
            // TS_bDTheoria
            // 
            this.TS_bDTheoria.Name = "TS_bDTheoria";
            this.TS_bDTheoria.Size = new System.Drawing.Size(152, 22);
            this.TS_bDTheoria.Text = "BD_Theoria";
            this.TS_bDTheoria.Click += new System.EventHandler(this.TS_bDTheoria_Click);
            // 
            // TS_bDMark
            // 
            this.TS_bDMark.Name = "TS_bDMark";
            this.TS_bDMark.Size = new System.Drawing.Size(152, 22);
            this.TS_bDMark.Text = "BD_Mark";
            this.TS_bDMark.Click += new System.EventHandler(this.TS_bDMark_Click);
            // 
            // TS_bDSchedule
            // 
            this.TS_bDSchedule.Name = "TS_bDSchedule";
            this.TS_bDSchedule.Size = new System.Drawing.Size(152, 22);
            this.TS_bDSchedule.Text = "BD_Schedule";
            this.TS_bDSchedule.Click += new System.EventHandler(this.TS_bDSchedule_Click);
            // 
            // TS_bDTranslate
            // 
            this.TS_bDTranslate.Name = "TS_bDTranslate";
            this.TS_bDTranslate.Size = new System.Drawing.Size(152, 22);
            this.TS_bDTranslate.Text = "BD_Translate";
            this.TS_bDTranslate.Click += new System.EventHandler(this.TS_bDTranslate_Click);
            // 
            // TS_bDTypeQuest
            // 
            this.TS_bDTypeQuest.Name = "TS_bDTypeQuest";
            this.TS_bDTypeQuest.Size = new System.Drawing.Size(152, 22);
            this.TS_bDTypeQuest.Text = "BD_TypeQuest";
            this.TS_bDTypeQuest.Click += new System.EventHandler(this.TS_bDTypeQuest_Click);
            // 
            // TS_bDTypeAnsw
            // 
            this.TS_bDTypeAnsw.Name = "TS_bDTypeAnsw";
            this.TS_bDTypeAnsw.Size = new System.Drawing.Size(152, 22);
            this.TS_bDTypeAnsw.Text = "BD_TypeAnsw";
            this.TS_bDTypeAnsw.Click += new System.EventHandler(this.TS_bDTypeAnsw_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Prigress});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // TS_Prigress
            // 
            this.TS_Prigress.Name = "TS_Prigress";
            this.TS_Prigress.Size = new System.Drawing.Size(152, 22);
            this.TS_Prigress.Text = "Успеваемость";
            this.TS_Prigress.Click += new System.EventHandler(this.TS_Prigress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 187);
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
        private System.Windows.Forms.ToolStripMenuItem TS_bDStudent;
        private System.Windows.Forms.ToolStripMenuItem TS_bDGroup;
        private System.Windows.Forms.ToolStripMenuItem TS_bDLessons;
        private System.Windows.Forms.ToolStripMenuItem TS_bDTheme;
        private System.Windows.Forms.ToolStripMenuItem TS_bDSubject;
        private System.Windows.Forms.ToolStripMenuItem TS_bDGroupSub;
        private System.Windows.Forms.ToolStripMenuItem TS_bDPractice;
        private System.Windows.Forms.ToolStripMenuItem TS_bDTheoria;
        private System.Windows.Forms.ToolStripMenuItem TS_bDMark;
        private System.Windows.Forms.ToolStripMenuItem TS_bDSchedule;
        private System.Windows.Forms.ToolStripMenuItem TS_bDTranslate;
        private System.Windows.Forms.ToolStripMenuItem TS_bDTypeQuest;
        private System.Windows.Forms.ToolStripMenuItem TS_bDTypeAnsw;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem TS_Prigress;
    }
}

