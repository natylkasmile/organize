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
    public partial class BD_Add_Stud : Form
    {
        public BD_Add_Stud()
        {
            InitializeComponent();
        }
        DCDataContext dt = new DCDataContext();

        private void BD_Add_Stud_Load(object sender, EventArgs e)
        {
            

        }

        private void TB_BDStud_group_Click(object sender, EventArgs e)
        {
            
            GV_BD_ST_GR.DataSource = dt.Peopl;
        }

        private void B_ADD_ST_Click(object sender, EventArgs e)
        {

            Student s = new Student()
            {
                FIO = TB_BDStud_name.Text,
                mail = TB_BDStud_mail.Text,
                groupID = Convert.ToInt32(TB_BDStud_group.Text)
            };
            dt.Student.InsertOnSubmit(s);
            dt.SubmitChanges();
            BD_Add_Stud.ActiveForm.Close();
        }

    }
}
