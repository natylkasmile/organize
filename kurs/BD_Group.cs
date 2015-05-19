using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class BD_Group : Form
    {
        public BD_Group()
        {
            InitializeComponent();
        }
        DCDataContext dt = new DCDataContext();

        private void B_Add_Gr_Click(object sender, EventArgs e)
        {
            Group G = new Group()
            {
                name_group = textBox1.Text
            };
            dt.Group.InsertOnSubmit(G);
            dt.SubmitChanges();
            dt = new DCDataContext();
            GV_BD_Group.DataSource = dt.Group;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var gr = dt.Group.Single(rec => rec.Id_group == Convert.ToInt32(GV_BD_Group.SelectedCells[0].Value));
            gr.name_group = textBox1.Text;
            dt.SubmitChanges();
            GV_BD_Group.DataSource = dt.Group;
        }

        private void GV_BD_Group_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = (GV_BD_Group.SelectedCells[1].Value).ToString();
            
        }

        private void BD_Group_Load(object sender, EventArgs e)
        {
            GV_BD_Group.DataSource = dt.Group;
            
        }

        private void B_Del_Group_Click(object sender, EventArgs e)
        {
             ok_candel oc = new ok_candel();
             oc.ShowDialog();
            if (oc.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dt.Group.DeleteOnSubmit(dt.Group.Where(elem => elem.Id_group == Convert.ToInt32(GV_BD_Group.SelectedCells[0].Value)).FirstOrDefault());
                dt.SubmitChanges();
                dt = new DCDataContext();
                GV_BD_Group.DataSource = dt.Group;
            }

            else { }
            
               
               

        }

        private void GV_BD_Group_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = (GV_BD_Group.SelectedCells[1].Value).ToString();
           
        }

        private void GV_BD_Group_Click(object sender, EventArgs e)
        {
        //    textBox1.Text = (GV_BD_Group.SelectedCells[1].Value).ToString();
            textBox1.Text = (GV_BD_Group.SelectedCells[0].Value).ToString(); 
        }
    }
}
