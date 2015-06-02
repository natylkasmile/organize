using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using OpenPop.Pop3;
using OpenPop.Mime;
using System.IO;
using System.Threading;

namespace отправка_писем
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            button2.Enabled = false;
        }

        string fileName;

      
        private void button2_Click(object sender, EventArgs e)
        {
            Авторизация av = new Авторизация();          
            SmtpClient clientSMTP = new SmtpClient("smtp.mail.ru", 587);
            MailAddress address = new MailAddress(textBox1.Text + "@mail.ru");
            MailMessage message = new MailMessage();
            message.To.Add(address);
            message.From = new MailAddress("swetoshek@mail.ru");    //(av.info_from[0]);
            message.IsBodyHtml = true;
            message.Subject = textBox2.Text;
            message.Body = textBox3.Text;
            clientSMTP.Credentials = new System.Net.NetworkCredential("swetoshek@mail.ru", "230717");     //(av.info_from[0], av.info_from[1]);
            clientSMTP.EnableSsl = true;
            if (fileName != "")
            {
                Attachment[] att = new Attachment[1];
                System.Net.Mail.Attachment attachment;                
                attachment = new System.Net.Mail.Attachment(@fileName);
                att[0] = attachment;
                message.Attachments.Add(att[0]);                
                clientSMTP.Send(message);
            }
            else
            {
                clientSMTP.Send(message);
            }
            MessageBox.Show("Ready !!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog chto_open = new OpenFileDialog();
            if (chto_open.ShowDialog() == DialogResult.OK)
            {                
                fileName = chto_open.FileName;
                pictureBox1.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "") button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Авторизация av = new Авторизация();
            av.ShowDialog();
        }
    }
}
