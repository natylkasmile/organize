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
    public partial class BD_Student : Form
    {
        public BD_Student()
        {
            InitializeComponent();
        }
        DCDataContext dt = new DCDataContext();

        
        private void B_ADD_BDStud_Click(object sender, EventArgs e)
        {
            BD_Add_Stud add = new BD_Add_Stud();
            add.ShowDialog();
            
            dt = new DCDataContext();
            GV_BDSTUD.DataSource = dt.Student;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_EDIT_BDStud_Click(object sender, EventArgs e)
        {
            var gr = dt.Student.Single(rec => rec.Id_student == Convert.ToInt32(GV_BDSTUD.SelectedCells[0].Value));
            gr.FIO = TB_BDStud_name.Text;
            gr.mail = TB_BDStud_mail.Text;
            gr.groupID = Convert.ToInt32(TB_BDStud_idgroup.Text);
            dt.SubmitChanges();
            GV_BDSTUD.DataSource = dt.Student;
        }

        private void B_DEL_BDStud_Click(object sender, EventArgs e)
        {
            ok_candel oc = new ok_candel();
            oc.ShowDialog();
            if (oc.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dt.Student.DeleteOnSubmit(dt.Student.Where(elem => elem.Id_student == Convert.ToInt32(GV_BDSTUD.SelectedCells[0].Value)).FirstOrDefault());
                dt.SubmitChanges();
                dt = new DCDataContext();
                GV_BDSTUD.DataSource = dt.Student;
            }

            else { }
        }

        private void BD_Student_Load(object sender, EventArgs e)
        {
            GV_BDSTUD.DataSource = dt.Student;
        }

        private void GV_BDSTUD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           TB_BDStud_name.Text = (GV_BDSTUD.SelectedCells[1].Value).ToString();
           TB_BDStud_mail.Text = (GV_BDSTUD.SelectedCells[2].Value).ToString();
           TB_BDStud_idgroup.Text = (GV_BDSTUD.SelectedCells[3].Value).ToString();
            
        }
    }
}
