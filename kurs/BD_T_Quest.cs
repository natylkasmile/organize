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
    public partial class BD_T_Quest : Form
    {
        public BD_T_Quest()
        {
            InitializeComponent();
        }
        DCDataContext dt = new DCDataContext();

        private void B_EDIT_BDTQuest_Click(object sender, EventArgs e)
        {
            var gr = dt.Type_question.Single(rec => rec.Id_tq == Convert.ToInt32(GV_BDTQuest.SelectedCells[0].Value));
            gr.tquestion = (GV_BDTQuest.SelectedCells[1].Value).ToString();
            dt.SubmitChanges();
            GV_BDTQuest.DataSource = dt.Type_question;
        }

        private void B_ADD_BDTQuest_Click(object sender, EventArgs e)
        {
            Type_question tq = new Type_question()
            {
                tquestion = TB_TQuest_name.Text
            };
            dt.Type_question.InsertOnSubmit(tq);
            dt.SubmitChanges();
            dt = new DCDataContext();
            GV_BDTQuest.DataSource = dt.Type_question;
        }

        private void B_DEL_BDTQuest_Click(object sender, EventArgs e)
        {
            ok_candel oc = new ok_candel();
            oc.ShowDialog();
            if (oc.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dt.Type_question.DeleteOnSubmit(dt.Type_question.Where(elem => elem.Id_tq == Convert.ToInt32(GV_BDTQuest.SelectedCells[0].Value)).FirstOrDefault());
                dt.SubmitChanges();
                dt = new DCDataContext();
                GV_BDTQuest.DataSource = dt.Type_question;
            }

            else { }
        }

        private void BD_T_Quest_Load(object sender, EventArgs e)
        {
            GV_BDTQuest.DataSource = dt.Type_question;
        }

        private void GV_BDTQuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_TQuest_name.Text = (GV_BDTQuest.SelectedCells[1].Value).ToString();
        }
    }
}
