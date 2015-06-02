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
    public partial class BD_Group_Sub : Form
    {
        public BD_Group_Sub()
        {
            InitializeComponent();
        }
        DCDataContext dt = new DCDataContext();

        private void B_ADD_BDG_S_Click(object sender, EventArgs e)
        {
            Add_GR_Sub gs = new Add_GR_Sub();
            gs.ShowDialog();
            
            dt = new DCDataContext();
            GV_BDG_S.DataSource = dt.Group_Sub;
        }

        private void B_EDIT_BDG_S_Click(object sender, EventArgs e)
        {
            var gr = dt.Group_Sub.Single(rec => rec.Id_rel == Convert.ToInt32(GV_BDG_S.SelectedCells[0].Value));
            gr.groupID = Convert.ToInt32(TB_BDG_S_gr.Text);
            gr.subID =Convert.ToInt32(TB_BDG_S_sub.Text);
            dt.SubmitChanges();
            GV_BDG_S.DataSource = dt.Group_Sub;
        }

        private void B_DEL_BDG_S_Click(object sender, EventArgs e)
        {
            ok_candel oc = new ok_candel();
            oc.ShowDialog();
            if (oc.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dt.Group_Sub.DeleteOnSubmit(dt.Group_Sub.Where(elem => elem.Id_rel == Convert.ToInt32(GV_BDG_S.SelectedCells[0].Value)).FirstOrDefault());
                dt.SubmitChanges();
                dt = new DCDataContext();
                GV_BDG_S.DataSource = dt.Group_Sub;
            }

            else { }
        }

        private void GV_BDG_S_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_BDG_S_gr.Text = (GV_BDG_S.SelectedCells[1].Value).ToString();
            TB_BDG_S_sub.Text = (GV_BDG_S.SelectedCells[2].Value).ToString();
        }

        private void BD_Group_Sub_Load(object sender, EventArgs e)
        {
            GV_BDG_S.DataSource = dt.Group_Sub;
        }
    }
}
