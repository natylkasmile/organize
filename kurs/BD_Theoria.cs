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
    public partial class BD_Theoria : Form
    {
        public BD_Theoria()
        {
            InitializeComponent();
        }
        DCDataContext dt = new DCDataContext();

        private void B_ADD_BDTheor_Click(object sender, EventArgs e)
        {
            Theor_ques tq = new Theor_ques()
            {
                qestion = TB_BDTheor_que.Text,
                themeID = Convert.ToInt32(TB_BDTheor_them.Text)
            };
            dt.Theor_ques.InsertOnSubmit(tq);
            dt.SubmitChanges();
            dt = new DCDataContext();
            GV_BDTheor.DataSource = dt.Theor_ques;

        }

        private void B_EDIT_BDTheor_Click(object sender, EventArgs e)
        {
            var gr = dt.Theor_ques.Single(rec => rec.Id_q == Convert.ToInt32(GV_BDTheor.SelectedCells[0].Value));
            gr.qestion = TB_BDTheor_que.Text;
            gr.themeID = Convert.ToInt32(TB_BDTheor_them.Text);
            dt.SubmitChanges();
            GV_BDTheor.DataSource = dt.Theor_ques;
        }

        private void B_DEL_BDTheor_Click(object sender, EventArgs e)
        {
            ok_candel oc = new ok_candel();
            oc.ShowDialog();
            if (oc.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dt.Theor_ques.DeleteOnSubmit(dt.Theor_ques.Where(elem => elem.Id_q == Convert.ToInt32(GV_BDTheor.SelectedCells[0].Value)).FirstOrDefault());
                dt.SubmitChanges();
                dt = new DCDataContext();
                GV_BDTheor.DataSource = dt.Theor_ques;
            }

            else { }
        }

        private void BD_Theoria_Load(object sender, EventArgs e)
        {
            GV_BDTheor.DataSource = dt.Theor_ques;
        }

        private void GV_BDTheor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_BDTheor_que.Text = (GV_BDTheor.SelectedCells[1].Value).ToString();
            TB_BDTheor_them.Text = (GV_BDTheor.SelectedCells[2].Value).ToString();
        }
    }
}
