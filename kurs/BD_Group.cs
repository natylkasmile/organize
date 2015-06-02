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
            Peopl G = new Peopl()
            {
                name_group = textBox1.Text
            };
            dt.Peopl.InsertOnSubmit(G);
            dt.SubmitChanges();
            dt = new DCDataContext();
            GV_BD_Group.DataSource = dt.Peopl;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // var gr = dt.Group.Single(rec => rec.Id_group == Convert.ToInt32(GV_BD_Group.SelectedCells[0].Value));
            var gr = dt.Peopl.Single(rec => rec.Id_group == Convert.ToInt32(GV_BD_Group.SelectedRows[0].Cells[0].Value));
           
            gr.name_group = textBox1.Text;
            dt.SubmitChanges();
            GV_BD_Group.DataSource = dt.Peopl;
        }

        private void GV_BD_Group_CellClick(object sender, DataGridViewCellEventArgs e)
        {
               
       }

        private void BD_Group_Load(object sender, EventArgs e)
        {
            GV_BD_Group.DataSource = dt.Peopl;
            
        }

        private void B_Del_Group_Click(object sender, EventArgs e)
        {
             ok_candel oc = new ok_candel();
             oc.ShowDialog();
            if (oc.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dt.Peopl.DeleteOnSubmit(dt.Peopl.Where(elem => elem.Id_group == Convert.ToInt32(GV_BD_Group.SelectedCells[0].Value)).FirstOrDefault());
                dt.SubmitChanges();
                dt = new DCDataContext();
                GV_BD_Group.DataSource = dt.Peopl;
            }

            else { }
            
               
               

        }

        private void GV_BD_Group_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           var  t = e.RowIndex;
           textBox1.Text = (GV_BD_Group.SelectedCells[0].Value).ToString();
            

        }
    }
}
