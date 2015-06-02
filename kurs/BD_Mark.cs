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
    public partial class BD_Mark : Form
    {
        public BD_Mark()
        {
            InitializeComponent();
        }
        DCDataContext dt = new DCDataContext();

        private void B_ADD_BDMark_Click(object sender, EventArgs e)
        {
            Mark mark = new Mark()
            {
                point = Convert.ToInt32(TB_BDMark_point.Text),
                date_p = DateTimeOffset.Parse(TB_BDMark_date.Text),
                lesID = Convert.ToInt32(TB_BDMark_les.Text),
                studID = Convert.ToInt32(TB_BDMark_Student.Text),
                subID = Convert.ToInt32(TB_BDMark_sub.Text)
            };
            dt.Mark.InsertOnSubmit(mark);
            dt.SubmitChanges();
            dt = new DCDataContext();
            GV_BDMark.DataSource = dt.Mark;
        }

        private void B_EDIT_BDMark_Click(object sender, EventArgs e)
        {
            var gr = dt.Mark.Single(rec => rec.Id_mark == Convert.ToInt32(GV_BDMark.SelectedCells[0].Value));
            gr.point = Convert.ToInt32(TB_BDMark_Student.Text);
            gr.date_p = DateTimeOffset.Parse(TB_BDMark_date.Text);
            gr.lesID = Convert.ToInt32(TB_BDMark_les.Text);
            gr.studID = Convert.ToInt32(TB_BDMark_Student.Text);
            gr.subID = Convert.ToInt32(TB_BDMark_sub.Text);
            dt.SubmitChanges();
            GV_BDMark.DataSource = dt.Mark;
        }

        private void B_DEL_BDMark_Click(object sender, EventArgs e)
        {
            ok_candel oc = new ok_candel();
            oc.ShowDialog();
            if (oc.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dt.Mark.DeleteOnSubmit(dt.Mark.Where(elem => elem.Id_mark == Convert.ToInt32(GV_BDMark.SelectedCells[0].Value)).FirstOrDefault());
                dt.SubmitChanges();
                dt = new DCDataContext();
                GV_BDMark.DataSource = dt.Mark;
            }

            else { }
        }

        private void BD_Mark_Load(object sender, EventArgs e)
        {
            GV_BDMark.DataSource = dt.Mark;
        }

        private void GV_BDMark_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_BDMark_point.Text = (GV_BDMark.SelectedCells[1].Value).ToString();
            TB_BDMark_date.Text =(GV_BDMark.SelectedCells[2].Value).ToString();
                TB_BDMark_les.Text = (GV_BDMark.SelectedCells[3].Value).ToString();
                TB_BDMark_Student.Text= (GV_BDMark.SelectedCells[4].Value).ToString();
                TB_BDMark_sub.Text = (GV_BDMark.SelectedCells[5].Value).ToString();
        }
    }
}
