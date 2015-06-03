using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenPop.Pop3;
using System.IO;


namespace почта
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pop3Client pop3Client = new Pop3Client();
            if (pop3Client.Connected) pop3Client.Disconnect();
            pop3Client.Connect("serverName", 25, true); // номер порта ???
            pop3Client.Authenticate("user", "user");

            textBox1.Text = pop3Client.GetMessageCount().ToString();
        }

        
    }
}
