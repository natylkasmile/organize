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
    public partial class BD_T_Answ : Form
    {
        public BD_T_Answ()
        {
            InitializeComponent();
        }
        DCDataContext dt = new DCDataContext();

        private void B_ADD_BDtansw_Click(object sender, EventArgs e)
        {
            Type_answer ta = new Type_answer()
            {
                tanswer = TB_BDTansw_ans.Text,
                questID = Convert.ToInt32(TB_BDTansw_ques.Text)
            };
            dt.Type_answer.InsertOnSubmit(ta);
            dt.SubmitChanges();
            dt = new DCDataContext();
            GV_BDTansw.DataSource = dt.Type_answer;
        }

        private void B_EDIT_BDtansw_Click(object sender, EventArgs e)
        {
            var gr = dt.Type_answer.Single(rec => rec.Id_ans == Convert.ToInt32(GV_BDTansw.SelectedCells[0].Value));
            gr.tanswer = (GV_BDTansw.SelectedCells[1].Value).ToString();
            dt.SubmitChanges();
            GV_BDTansw.DataSource = dt.Type_answer;
        }

        private void B_DEL_BDtansw_Click(object sender, EventArgs e)
        {
            ok_candel oc = new ok_candel();
            oc.ShowDialog();
            if (oc.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dt.Type_answer.DeleteOnSubmit(dt.Type_answer.Where(elem => elem.Id_ans == Convert.ToInt32(GV_BDTansw.SelectedCells[0].Value)).FirstOrDefault());
                dt.SubmitChanges();
                dt = new DCDataContext();
                GV_BDTansw.DataSource = dt.Type_answer;
            }

            else { }
        }

        private void BD_T_Answ_Load(object sender, EventArgs e)
        {
            GV_BDTansw.DataSource = dt.Type_answer;
        }

        private void GV_BDTansw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_BDTansw_ans.Text = (GV_BDTansw.SelectedCells[1].Value).ToString();
            TB_BDTansw_ques.Text = (GV_BDTansw.SelectedCells[2].Value).ToString();
        }
    }
}
