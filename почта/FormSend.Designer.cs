namespace почта
{
    partial class FormSend
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
            this.Send = new System.Windows.Forms.Button();
            this.TBTo = new System.Windows.Forms.TextBox();
            this.TBSubject = new System.Windows.Forms.TextBox();
            this.TBText = new System.Windows.Forms.TextBox();
            this.LTo = new System.Windows.Forms.Label();
            this.LSubject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BFale = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(171, 263);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 0;
            this.Send.Text = "Отправить";
            this.Send.UseVisualStyleBackColor = true;
            // 
            // TBTo
            // 
            this.TBTo.Location = new System.Drawing.Point(171, 20);
            this.TBTo.Name = "TBTo";
            this.TBTo.Size = new System.Drawing.Size(128, 20);
            this.TBTo.TabIndex = 1;
            this.TBTo.TextChanged += new System.EventHandler(this.TBTo_TextChanged);
            // 
            // TBSubject
            // 
            this.TBSubject.Location = new System.Drawing.Point(171, 51);
            this.TBSubject.Name = "TBSubject";
            this.TBSubject.Size = new System.Drawing.Size(222, 20);
            this.TBSubject.TabIndex = 2;
            // 
            // TBText
            // 
            this.TBText.Location = new System.Drawing.Point(15, 115);
            this.TBText.Multiline = true;
            this.TBText.Name = "TBText";
            this.TBText.Size = new System.Drawing.Size(378, 142);
            this.TBText.TabIndex = 3;
            // 
            // LTo
            // 
            this.LTo.AutoSize = true;
            this.LTo.Location = new System.Drawing.Point(12, 23);
            this.LTo.Name = "LTo";
            this.LTo.Size = new System.Drawing.Size(142, 13);
            this.LTo.TabIndex = 4;
            this.LTo.Text = "Введите адрес получателя";
            // 
            // LSubject
            // 
            this.LSubject.AutoSize = true;
            this.LSubject.Location = new System.Drawing.Point(12, 54);
            this.LSubject.Name = "LSubject";
            this.LSubject.Size = new System.Drawing.Size(75, 13);
            this.LSubject.TabIndex = 5;
            this.LSubject.Text = "Тема письма";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Прикрепить файл";
            // 
            // BFale
            // 
            this.BFale.Location = new System.Drawing.Point(171, 77);
            this.BFale.Name = "BFale";
            this.BFale.Size = new System.Drawing.Size(75, 26);
            this.BFale.TabIndex = 7;
            this.BFale.Text = "Обзор";
            this.BFale.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox1.Location = new System.Drawing.Point(252, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 25);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "@mail.ru",
            "@gmail.ru",
            "@yandex.ru"});
            this.listBox1.Location = new System.Drawing.Point(305, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(103, 17);
            this.listBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BFale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LSubject);
            this.Controls.Add(this.LTo);
            this.Controls.Add(this.TBText);
            this.Controls.Add(this.TBSubject);
            this.Controls.Add(this.TBTo);
            this.Controls.Add(this.Send);
            this.Name = "FormSend";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox TBTo;
        private System.Windows.Forms.TextBox TBSubject;
        private System.Windows.Forms.TextBox TBText;
        private System.Windows.Forms.Label LTo;
        private System.Windows.Forms.Label LSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BFale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

