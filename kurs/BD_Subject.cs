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
    public partial class BD_Subject : Form
    {
        public BD_Subject()
        {
            InitializeComponent();
        }
        DCDataContext dt = new DCDataContext();

        private void B_ADD_BDSub_Click(object sender, EventArgs e)
        {
            Subject sub = new Subject()
            {
                name_sub= TB_BDSub_name.Text
            };
            dt.Subject.InsertOnSubmit(sub);
            dt.SubmitChanges();
            dt = new DCDataContext();
            GV_BDSub.DataSource = dt.Subject;

        }

        private void B_EDIT_BDSub_Click(object sender, EventArgs e)
        {
            var gr = dt.Subject.Single(rec => rec.Id_sub == Convert.ToInt32(GV_BDSub.SelectedCells[0].Value));
            gr.name_sub = TB_BDSub_name.Text;
            dt.SubmitChanges();
            GV_BDSub.DataSource = dt.Subject;
        }

        private void B_DEL_BDSub_Click(object sender, EventArgs e)
        {
            ok_candel oc = new ok_candel();
            oc.ShowDialog();
            if (oc.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dt.Subject.DeleteOnSubmit(dt.Subject.Where(elem => elem.Id_sub == Convert.ToInt32(GV_BDSub.SelectedCells[0].Value)).FirstOrDefault());
                dt.SubmitChanges();
                dt = new DCDataContext();
                GV_BDSub.DataSource = dt.Subject;
            }

            else { }
        }

        private void GV_BDSub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_BDSub_name.Text = (GV_BDSub.SelectedCells[1].Value).ToString();
           
        }

        private void BD_Subject_Load(object sender, EventArgs e)
        {
            GV_BDSub.DataSource = dt.Subject;
        }
    }
}
