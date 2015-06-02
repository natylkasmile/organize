using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace отправка_писем
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        public string[] info_from = new string[1];

        private void button1_Click(object sender, EventArgs e)
        {            
                string[] info_from = new string[2];
                if ((textBox1.Text == "") && (textBox2.Text == ""))
                {
                    MessageBox.Show("Заполните поля !");                    
                }
                else
                {                    
                    info_from[0] = textBox1.Text + "@mail.ru";
                    info_from[1] = textBox2.Text;
                }
                Авторизация.ActiveForm.Close();
        }
    }
}
