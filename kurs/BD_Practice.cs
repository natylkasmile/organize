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
    public partial class BD_Practice : Form
    {
        public BD_Practice()
        {
            InitializeComponent();
        }
        DCDataContext dt = new DCDataContext();
        
        private void B_ADD_BDPrac_Click(object sender, EventArgs e)
        {
            Practice pr = new Practice()
            {
                practice1 = TB_BDPrac_name.Text,
                themeID = Convert.ToInt32(TB_BDPrac_Theme.Text)
            };
            dt.Practice.InsertOnSubmit(pr);
            dt.SubmitChanges();
            dt = new DCDataContext();
            GV_BDPrac.DataSource = dt.Practice;

        }

        private void B_EDIT_BDPrac_Click(object sender, EventArgs e)
        {
            var gr = dt.Practice.Single(rec => rec.Id_pr == Convert.ToInt32(GV_BDPrac.SelectedCells[0].Value));
            gr.practice1 = TB_BDPrac_name.Text;
            gr.themeID = Convert.ToInt32(TB_BDPrac_Theme.Text);
            dt.SubmitChanges();
            GV_BDPrac.DataSource = dt.Practice;
        }

        private void B_DEL_BDPrac_Click(object sender, EventArgs e)
        {
            ok_candel oc = new ok_candel();
            oc.ShowDialog();
            if (oc.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dt.Practice.DeleteOnSubmit(dt.Practice.Where(elem => elem.Id_pr == Convert.ToInt32(GV_BDPrac.SelectedCells[0].Value)).FirstOrDefault());
                dt.SubmitChanges();
                dt = new DCDataContext();
                GV_BDPrac.DataSource = dt.Practice;
            }

            else { }
        }

        private void BD_Practice_Load(object sender, EventArgs e)
        {
            GV_BDPrac.DataSource = dt.Practice;
        }

        private void GV_BDPrac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_BDPrac_name.Text = (GV_BDPrac.SelectedCells[1].Value).ToString();
            TB_BDPrac_Theme.Text = (GV_BDPrac.SelectedCells[2].Value).ToString();
        }
    }
}
