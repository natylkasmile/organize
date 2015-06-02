namespace kurs
{
    partial class Otchet
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
            this.B_SAVE_Rez = new System.Windows.Forms.Button();
            this.PB_otchet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_otchet)).BeginInit();
            this.SuspendLayout();
            // 
            // B_SAVE_Rez
            // 
            this.B_SAVE_Rez.Location = new System.Drawing.Point(0, 329);
            this.B_SAVE_Rez.Name = "B_SAVE_Rez";
            this.B_SAVE_Rez.Size = new System.Drawing.Size(75, 23);
            this.B_SAVE_Rez.TabIndex = 1;
            this.B_SAVE_Rez.Text = "button1";
            this.B_SAVE_Rez.UseVisualStyleBackColor = true;
            // 
            // PB_otchet
            // 
            this.PB_otchet.Location = new System.Drawing.Point(0, 12);
            this.PB_otchet.Name = "PB_otchet";
            this.PB_otchet.Size = new System.Drawing.Size(784, 277);
            this.PB_otchet.TabIndex = 2;
            this.PB_otchet.TabStop = false;
            // 
            // Otchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 396);
            this.Controls.Add(this.PB_otchet);
            this.Controls.Add(this.B_SAVE_Rez);
            this.Name = "Otchet";
            this.Text = "Otchet";
            this.Load += new System.EventHandler(this.Otchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_otchet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_SAVE_Rez;
        private System.Windows.Forms.PictureBox PB_otchet;
    }
}