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
    public partial class BD_Translate : Form
    {
        public BD_Translate()
        {
            InitializeComponent();
        }
        DCDataContext dt = new DCDataContext();

        private void B_ADD_BDtran_Click(object sender, EventArgs e)
        {
            Translate tr = new Translate()
            {
                max_point = Convert.ToInt32(TB_BDtran_max.Text),
                _34point = Convert.ToInt32(TB_BDtran_34.Text),
                _45point = Convert.ToInt32(TB_BDtran_45.Text),
                min_point = Convert.ToInt32(TB_BDtran_min.Text),
                subID = Convert.ToInt32(TB_BDtran_sub.Text),
                lesID = Convert.ToInt32(TB_BDtran_les.Text)
            };
            dt.Translate.InsertOnSubmit(tr);
            dt.SubmitChanges();
            dt = new DCDataContext();
            GV_BDTrans.DataSource = dt.Translate;

        }

        private void B_EDIT_BDtran_Click(object sender, EventArgs e)
        {
            var gr = dt.Translate.Single(rec => rec.Id_trans == Convert.ToInt32(GV_BDTrans.SelectedCells[0].Value));
            gr.max_point = Convert.ToInt32(TB_BDtran_max.Text);
            gr._34point = Convert.ToInt32(TB_BDtran_34.Text);
            gr._45point = Convert.ToInt32(TB_BDtran_45.Text);
            gr.min_point = Convert.ToInt32(TB_BDtran_min.Text);
            gr.subID = Convert.ToInt32(TB_BDtran_sub.Text);
            gr.lesID = Convert.ToInt32(TB_BDtran_les.Text);
            dt.SubmitChanges();
            GV_BDTrans.DataSource = dt.Translate;
        }

        private void B_DEL_BDtran_Click(object sender, EventArgs e)
        {
            ok_candel oc = new ok_candel();
            oc.ShowDialog();
            if (oc.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dt.Translate.DeleteOnSubmit(dt.Translate.Where(elem => elem.Id_trans == Convert.ToInt32(GV_BDTrans.SelectedCells[0].Value)).FirstOrDefault());
                dt.SubmitChanges();
                dt = new DCDataContext();
                GV_BDTrans.DataSource = dt.Translate;
            }

            else { }
        }

        private void BD_Translate_Load(object sender, EventArgs e)
        {
            GV_BDTrans.DataSource = dt.Translate;
        }

        private void GV_BDTrans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_BDtran_max.Text = (GV_BDTrans.SelectedCells[1].Value).ToString();
            TB_BDtran_34.Text = (GV_BDTrans.SelectedCells[2].Value).ToString();
            TB_BDtran_45.Text = (GV_BDTrans.SelectedCells[3].Value).ToString();
            TB_BDtran_min.Text = (GV_BDTrans.SelectedCells[4].Value).ToString();
            TB_BDtran_sub.Text = (GV_BDTrans.SelectedCells[5].Value).ToString();
            TB_BDtran_les.Text = (GV_BDTrans.SelectedCells[6].Value).ToString();
        }
    }
}
