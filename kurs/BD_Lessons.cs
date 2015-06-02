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
    public partial class BD_Lessons : Form
    {
        public BD_Lessons()
        {
            InitializeComponent();
        }
        DCDataContext dt = new DCDataContext();
        private void B_Add_BDLES_Click(object sender, EventArgs e)
        {
            Lessons les = new Lessons() 
            {
                type_les = textBox1.Text
            };
            
            dt.Lessons.InsertOnSubmit(les);
            dt.SubmitChanges();
            dt = new DCDataContext();
            GV_BDLES.DataSource = dt.Lessons;
        }

        private void B_EDIT_BDLES_Click(object sender, EventArgs e)
        {
            var gr = dt.Lessons.Single(rec => rec.Id_les == Convert.ToInt32(GV_BDLES.SelectedCells[0].Value));
            gr.type_les = textBox1.Text;
            dt.SubmitChanges();
            GV_BDLES.DataSource = dt.Lessons;
        }

        private void B_DEL_BDLES_Click(object sender, EventArgs e)
        {
            ok_candel oc = new ok_candel();
            oc.ShowDialog();
            if (oc.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dt.Lessons.DeleteOnSubmit(dt.Lessons.Where(elem => elem.Id_les == Convert.ToInt32(GV_BDLES.SelectedCells[0].Value)).FirstOrDefault());
                dt.SubmitChanges();
                dt = new DCDataContext();
                GV_BDLES.DataSource = dt.Lessons;
            }

            else { }
        }

        private void BD_Lessons_Load(object sender, EventArgs e)
        {
            GV_BDLES.DataSource = dt.Lessons;
        }

        private void GV_BDLES_Click(object sender, EventArgs e)
        {

        }

        private void GV_BDLES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = (GV_BDLES.SelectedCells[1].Value).ToString();
        }

        
    }
}
