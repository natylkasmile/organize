using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using OpenPop.Pop3;
using OpenPop.Mime;
using System.IO;
using System.Threading;

namespace почта
{    

    public partial class FormSend : Form
    {
        public FormSend()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            Send.Enabled = false;
        }

        //string open;        

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 25);
        //        Smtp.Credentials = new NetworkCredential("user", "user");
        //        MailMessage Message = new MailMessage();
        //        Message.From = new MailAddress("student@mail.ru");//от кого
        //        Message.To.Add(new MailAddress(TBTo.Text));//кому
        //        Message.Subject = TBSubject.Text;//тема
        //        Message.Body = TBText.Text;//текст письма

        //        string file = open;
        //        Attachment attach = new Attachment(file, MediaTypeNames.Application.Octet);
        //        Message.Attachments.Add(attach);

        //        Smtp.Send(Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error !");
        //    }
        //}

        //private void BFale_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog chto_open = new OpenFileDialog();
        //    if (chto_open.ShowDialog() == DialogResult.OK)
        //    {
        //        open = chto_open.SafeFileName;
        //        pictureBox1.Visible = true;
        //    }
        //}

        private void TBTo_TextChanged(object sender, EventArgs e)
        {
            if (TBTo.Text != "") Send.Enabled = true;
        }

        public static void Send_Click(string emailreceiver, string myemailadd, string theme, string messbody, string password, string server, string fileName)
        {
            SmtpClient clientSMTP = new SmtpClient(server, 587);

            MailAddress address = new MailAddress(emailreceiver);
            MailMessage message = new MailMessage();
            message.To.Add(address);
            message.From = new MailAddress(myemailadd + "@mail.ru");
            message.IsBodyHtml = true;
            message.Subject = theme;
            message.Body = messbody;
            clientSMTP.Credentials = new System.Net.NetworkCredential(myemailadd, password);
            clientSMTP.EnableSsl = true;
            if (fileName != "")
            {
                Attachment[] att = new Attachment[0];
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

            MessageBox.Show("Ready !");
         //  ClassForms.sf.label1.Text += Environment.NewLine + "Отправлено сообщение: ";
          //  ClassForms.sf.label1.Text += emailreceiver + ".";
          //  ClassForms.sf.label1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();


        }
        /// <summary>
        /// функция скачивания сообщения с сервера
        /// </summary>
        /// <param name="hostname"></param>
        /// <param name="port"></param>
        /// <param name="useSsl"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="allMessages"></param>
        /// <returns></returns>
        public static string FetchAllMessages(string hostname, int port, bool useSsl, string username, string password, List<OpenPop.Mime.Message> allMessages)
        {
          //  string result;
            try
            {
                using (Pop3Client client = new Pop3Client())
                {
                    client.Connect(hostname, port, useSsl);
                    client.Authenticate(username, password);
                    string text = "";
                    int messageCount = client.GetMessageCount();

                    for (int i = messageCount; i > 0; i--)
                    {
                        allMessages.Add(client.GetMessage(i));
                    }
                    foreach (OpenPop.Mime.Message message in allMessages)
                    {
                        var att = message.FindAllAttachments();
                        MessagePart mpPlain = message.FindFirstPlainTextVersion();
                        if (mpPlain != null)
                        {
                            Encoding enc = mpPlain.BodyEncoding;
                            text = enc.GetString(mpPlain.Body);
                        }
                        text += message.Headers.Subject;
                        string[] text_ot = text.Split(' ');
                        string date_mes;
                        date_mes = message.Headers.DateSent.ToShortDateString();
                        for (int i = 0; i < text_ot.Count(); i++)
                        {
                            if (text_ot[i].ToLower() == "экзамен" || text_ot[i].ToLower() == "продажа" || text_ot[i].ToLower() == "отчеты" || text_ot[i].ToLower() == "продажах")
                            {
                                if (File.Exists(@"Отчеты о продажах\" + date_mes + "_" + "отчет" + ".xlsx") == false) //папка в bin
                                {

                                    foreach (var ado in att)
                                    {
                                        if (ado.FileName.EndsWith(".xlsx") || ado.FileName.EndsWith(".xls"))
                                        {
                                            ado.Save(new System.IO.FileInfo(System.IO.Path.Combine(@"Отчеты о продажах", date_mes + "_отчет.xlsx")));
                                           // Check_table check = new Check_table();
                                            //check.read_selling(date_mes + "_" + "отчет" + ".xlsx");
                                        }


                                    }
                                }
                            }
                            else
                            {
                                foreach (var ado in att)
                                {
                                    ado.Save(new System.IO.FileInfo(System.IO.Path.Combine(@"Неопределенные документы", ado.FileName))); //остальные прикрепления без упоминаний 
                                }
                            }
                        }
                    }

                }
                return result = "Ok";
            }
            catch
            {
                return result = "Fail";
            }
        }
    



       
    }
}
