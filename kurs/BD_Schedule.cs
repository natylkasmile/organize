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
    public partial class BD_Schedule : Form
    {
        public BD_Schedule()
        {
            InitializeComponent();
        }
        DCDataContext dt = new DCDataContext();

        private void B_Add_BDSched_Click(object sender, EventArgs e)
        {
            Schedule sch = new Schedule()
            {
                day = Convert.ToInt32(TB_BDSched_day.Text),
                pair = Convert.ToInt32(TB_BDSched_pair.Text),
                lesID = Convert.ToInt32(TB_BDSched_les.Text),
                relID = Convert.ToInt32(TB_BDSched_rel)
            };
            dt.Schedule.InsertOnSubmit(sch);
            dt.SubmitChanges();
            dt = new DCDataContext();
            GV_BDSched.DataSource = dt.Schedule;
            

        }

        private void B_EDIT_BDSched_Click(object sender, EventArgs e)
        {
            var gr = dt.Schedule.Single(rec => rec.Id_sh == Convert.ToInt32(GV_BDSched.SelectedCells[0].Value));
            gr.day = Convert.ToInt32(TB_BDSched_day.Text);
            gr.pair = Convert.ToInt32(TB_BDSched_pair.Text);
            gr.lesID = Convert.ToInt32(TB_BDSched_les.Text);
            gr.relID = Convert.ToInt32(TB_BDSched_rel.Text);
            dt.SubmitChanges();
            GV_BDSched.DataSource = dt.Schedule;
        }

        private void B_DEL_BDSched_Click(object sender, EventArgs e)
        {
            ok_candel oc = new ok_candel();
            oc.ShowDialog();
            if (oc.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dt.Schedule.DeleteOnSubmit(dt.Schedule.Where(elem => elem.Id_sh == Convert.ToInt32(GV_BDSched.SelectedCells[0].Value)).FirstOrDefault());
                dt.SubmitChanges();
                dt = new DCDataContext();
                GV_BDSched.DataSource = dt.Schedule;
            }

            else { }
        }

        private void BD_Schedule_Load(object sender, EventArgs e)
        {
            GV_BDSched.DataSource = dt.Schedule;
        }

        private void GV_BDSched_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_BDSched_day.Text = (GV_BDSched.SelectedCells[1].Value).ToString();
            TB_BDSched_pair.Text = (GV_BDSched.SelectedCells[2].Value).ToString();
            TB_BDSched_les.Text = (GV_BDSched.SelectedCells[3].Value).ToString();
            TB_BDSched_rel.Text = (GV_BDSched.SelectedCells[4].Value).ToString();
        }
    }
}
