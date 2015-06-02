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
    public partial class Add_GR_Sub : Form
    {
        public Add_GR_Sub()
        {
            InitializeComponent();
        }
        DCDataContext dt = new DCDataContext();

        private void textBox1_Click(object sender, EventArgs e)
        {
            GV_Add_G_S.DataSource = dt.Peopl;
        }

        private void TB_AddG_S_SU_Click(object sender, EventArgs e)
        {
            GV_Add_G_S.DataSource = dt.Subject;
        }

        private void B_ADD_G_SUB_Click(object sender, EventArgs e)
        {
            Group_Sub gs = new Group_Sub()
            {
                groupID = Convert.ToInt32(TB_ADDG_S_GR.Text),
                subID = Convert.ToInt32(TB_AddG_S_SU.Text)
            };
            dt.Group_Sub.InsertOnSubmit(gs);
            dt.SubmitChanges();
            Add_GR_Sub.ActiveForm.Close();

        }
    }
}
