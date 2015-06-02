namespace kurs
{
    partial class Save_Rez
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
            this.B_Save_rez = new System.Windows.Forms.Button();
            this.B_Unsave_Rez = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_Save_rez
            // 
            this.B_Save_rez.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.B_Save_rez.Location = new System.Drawing.Point(30, 92);
            this.B_Save_rez.Name = "B_Save_rez";
            this.B_Save_rez.Size = new System.Drawing.Size(75, 23);
            this.B_Save_rez.TabIndex = 0;
            this.B_Save_rez.Text = "Сохранить результаты";
            this.B_Save_rez.UseVisualStyleBackColor = true;
            this.B_Save_rez.Click += new System.EventHandler(this.B_Save_rez_Click);
            // 
            // B_Unsave_Rez
            // 
            this.B_Unsave_Rez.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_Unsave_Rez.Location = new System.Drawing.Point(172, 92);
            this.B_Unsave_Rez.Name = "B_Unsave_Rez";
            this.B_Unsave_Rez.Size = new System.Drawing.Size(75, 23);
            this.B_Unsave_Rez.TabIndex = 1;
            this.B_Unsave_Rez.Text = "Отмена";
            this.B_Unsave_Rez.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сохранить результаты?";
            // 
            // Save_Rez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 147);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Unsave_Rez);
            this.Controls.Add(this.B_Save_rez);
            this.Name = "Save_Rez";
            this.Text = "Save_Rez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Save_rez;
        private System.Windows.Forms.Button B_Unsave_Rez;
        private System.Windows.Forms.Label label1;

    }
}