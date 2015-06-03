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
using System.Net.Sockets;
using System.IO;


namespace почта
{
    public partial class FormTake : Form
    {
        public FormTake()
        {
            InitializeComponent();
        }

        string response = null;
        string from = null;
        string subject = null;
        int totmessages = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            TcpClient mailclient = null;
            try
            {
                mailclient = new TcpClient("pop3.mail.ru", 110);
            }
            catch (SocketException)
            {
                Console.WriteLine("Unable to connect to server");
                Console.ReadLine();
                return;
            }

            NetworkStream ns = mailclient.GetStream();
            StreamReader sr = new StreamReader(ns, Encoding.GetEncoding("windows-1251"));
            StreamWriter sw = new StreamWriter(ns);
            response = sr.ReadLine(); //открываем «диалог»
            sw.WriteLine("User " + "username"); //Передаем имя пользователя
            sw.Flush();
            response = sr.ReadLine();
            if (response.Substring(0, 3) == "-ER")//если сервер ответил «ошибка»
            {
                Console.WriteLine("Unable to log into server");
                Console.ReadLine();
                return; // прерываем «диалог»
            }
            sw.WriteLine("Pass " + "password"); //Передаем пароль
            sw.Flush();
            try
            {// если авторизация прошла успешно
                response = sr.ReadLine(); //получим ответ от сервера
            }
            catch (IOException)
            {
                Console.WriteLine("Unable to log into server");
                Console.ReadLine();
                return; //иначе прерываем «диалог»
            }
            if (response.Substring(0, 4) == "-ERR")//если сервер ответил «ошибка»
            {
                Console.WriteLine("Unable to log into server");
                Console.ReadLine();
                return; // прерываем «диалог»
            }
            sw.WriteLine("stat"); //Посылаем запрос на статистику почтового ящика
            sw.Flush();
            response = sr.ReadLine();
            string[] nummess = response.Split(' ');
            totmessages = Convert.ToInt16(nummess[1]);
            if (totmessages > 0)
            {
                Console.WriteLine("you have " + totmessages + " messages");
            }
            else
            {
                Console.WriteLine("You have no messages");
            }

            for (int i = 1; i <= totmessages; i++)
            {
                sw.WriteLine("top " + i + " 0"); //читаем заголовки каждого письма
                sw.Flush();
                while (true)
                {
                    response = sr.ReadLine();
                    if (response == ".")
                        break;
                    if (response.Length > 4)
                    {
                        if (response.Substring(0, 5) == "From:")
                            from = response;
                        if (response.Substring(0, 8) == "Subject:")
                            subject = response;
                    }
                }
                Console.WriteLine(i + " " + from + " " + subject);

            }
            MessageBox.Show("Всё !");
        }

    }
}
