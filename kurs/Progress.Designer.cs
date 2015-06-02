namespace kurs
{
    partial class Progress
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
            this.PB_progres = new System.Windows.Forms.PictureBox();
            this.RB_stud = new System.Windows.Forms.RadioButton();
            this.RB_group = new System.Windows.Forms.RadioButton();
            this.GB_Progress = new System.Windows.Forms.GroupBox();
            this.B_Prog_grah = new System.Windows.Forms.Button();
            this.LB_Progres = new System.Windows.Forms.ListBox();
            this.GB_Prog_Sub = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.LB_Progres_rez = new System.Windows.Forms.ListBox();
            this.CB_Rez_Date = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_progres)).BeginInit();
            this.GB_Progress.SuspendLayout();
            this.GB_Prog_Sub.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_progres
            // 
            this.PB_progres.Location = new System.Drawing.Point(12, 12);
            this.PB_progres.Name = "PB_progres";
            this.PB_progres.Size = new System.Drawing.Size(564, 277);
            this.PB_progres.TabIndex = 0;
            this.PB_progres.TabStop = false;
            // 
            // RB_stud
            // 
            this.RB_stud.AutoSize = true;
            this.RB_stud.Location = new System.Drawing.Point(6, 19);
            this.RB_stud.Name = "RB_stud";
            this.RB_stud.Size = new System.Drawing.Size(171, 17);
            this.RB_stud.TabIndex = 1;
            this.RB_stud.TabStop = true;
            this.RB_stud.Text = "Успеваемость по студентам";
            this.RB_stud.UseVisualStyleBackColor = true;
            this.RB_stud.CheckedChanged += new System.EventHandler(this.RB_stud_CheckedChanged);
            // 
            // RB_group
            // 
            this.RB_group.AutoSize = true;
            this.RB_group.Location = new System.Drawing.Point(6, 42);
            this.RB_group.Name = "RB_group";
            this.RB_group.Size = new System.Drawing.Size(160, 17);
            this.RB_group.TabIndex = 2;
            this.RB_group.TabStop = true;
            this.RB_group.Text = "Успеваемость по группам";
            this.RB_group.UseVisualStyleBackColor = true;
            this.RB_group.CheckedChanged += new System.EventHandler(this.RB_group_CheckedChanged);
            // 
            // GB_Progress
            // 
            this.GB_Progress.Controls.Add(this.RB_stud);
            this.GB_Progress.Controls.Add(this.RB_group);
            this.GB_Progress.Location = new System.Drawing.Point(12, 310);
            this.GB_Progress.Name = "GB_Progress";
            this.GB_Progress.Size = new System.Drawing.Size(186, 65);
            this.GB_Progress.TabIndex = 3;
            this.GB_Progress.TabStop = false;
            this.GB_Progress.Text = "Выберите отчет";
            this.GB_Progress.Enter += new System.EventHandler(this.GB_Progress_Enter);
            // 
            // B_Prog_grah
            // 
            this.B_Prog_grah.Enabled = false;
            this.B_Prog_grah.Location = new System.Drawing.Point(582, 310);
            this.B_Prog_grah.Name = "B_Prog_grah";
            this.B_Prog_grah.Size = new System.Drawing.Size(192, 23);
            this.B_Prog_grah.TabIndex = 4;
            this.B_Prog_grah.Text = "Посторить график успеваемости";
            this.B_Prog_grah.UseVisualStyleBackColor = true;
            this.B_Prog_grah.Click += new System.EventHandler(this.B_Prog_grah_Click);
            // 
            // LB_Progres
            // 
            this.LB_Progres.FormattingEnabled = true;
            this.LB_Progres.Location = new System.Drawing.Point(410, 310);
            this.LB_Progres.Name = "LB_Progres";
            this.LB_Progres.Size = new System.Drawing.Size(166, 147);
            this.LB_Progres.TabIndex = 5;
            this.LB_Progres.Click += new System.EventHandler(this.LB_Progres_Click);
            // 
            // GB_Prog_Sub
            // 
            this.GB_Prog_Sub.Controls.Add(this.radioButton3);
            this.GB_Prog_Sub.Controls.Add(this.radioButton2);
            this.GB_Prog_Sub.Controls.Add(this.radioButton1);
            this.GB_Prog_Sub.Location = new System.Drawing.Point(204, 310);
            this.GB_Prog_Sub.Name = "GB_Prog_Sub";
            this.GB_Prog_Sub.Size = new System.Drawing.Size(200, 100);
            this.GB_Prog_Sub.TabIndex = 6;
            this.GB_Prog_Sub.TabStop = false;
            this.GB_Prog_Sub.Text = "Выберите предмет";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "3";
            this.radioButton3.Text = "3предмет";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "2предмет";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "1предмет";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // LB_Progres_rez
            // 
            this.LB_Progres_rez.FormattingEnabled = true;
            this.LB_Progres_rez.Location = new System.Drawing.Point(582, 362);
            this.LB_Progres_rez.Name = "LB_Progres_rez";
            this.LB_Progres_rez.Size = new System.Drawing.Size(214, 95);
            this.LB_Progres_rez.TabIndex = 7;
            // 
            // CB_Rez_Date
            // 
            this.CB_Rez_Date.FormattingEnabled = true;
            this.CB_Rez_Date.Items.AddRange(new object[] {
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь",
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь"});
            this.CB_Rez_Date.Location = new System.Drawing.Point(12, 389);
            this.CB_Rez_Date.Name = "CB_Rez_Date";
            this.CB_Rez_Date.Size = new System.Drawing.Size(121, 21);
            this.CB_Rez_Date.TabIndex = 8;
            this.CB_Rez_Date.Text = "Выберите месяц";
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 452);
            this.Controls.Add(this.CB_Rez_Date);
            this.Controls.Add(this.LB_Progres_rez);
            this.Controls.Add(this.GB_Prog_Sub);
            this.Controls.Add(this.LB_Progres);
            this.Controls.Add(this.B_Prog_grah);
            this.Controls.Add(this.GB_Progress);
            this.Controls.Add(this.PB_progres);
            this.Name = "Progress";
            this.Text = "Progress";
            ((System.ComponentModel.ISupportInitialize)(this.PB_progres)).EndInit();
            this.GB_Progress.ResumeLayout(false);
            this.GB_Progress.PerformLayout();
            this.GB_Prog_Sub.ResumeLayout(false);
            this.GB_Prog_Sub.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_progres;
        private System.Windows.Forms.RadioButton RB_stud;
        private System.Windows.Forms.RadioButton RB_group;
        private System.Windows.Forms.GroupBox GB_Progress;
        private System.Windows.Forms.Button B_Prog_grah;
        private System.Windows.Forms.ListBox LB_Progres;
        private System.Windows.Forms.GroupBox GB_Prog_Sub;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox LB_Progres_rez;
        private System.Windows.Forms.ComboBox CB_Rez_Date;
    }
}