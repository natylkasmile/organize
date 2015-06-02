using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;


namespace kurs
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
             
        }
        SystemOfMark sys = new SystemOfMark();

        DCDataContext dc = new DCDataContext();
        static string s = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Наташа\Desktop\kurs_bd\bd.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter da = new SqlDataAdapter("Select * from Student", s);
        SqlDataAdapter da2 = new SqlDataAdapter("Select * from Peopl", s);
        DataSet ds = new DataSet();
        
        SaveToPDF stp = new SaveToPDF();
        string namesave = null;

        bool typ = true;
        private void RB_stud_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            typ = true;
            LB_Progres.Items.Clear();
            da.Fill(ds, "Student");
            DataTable dt = ds.Tables["Student"];
            var q = dt.AsEnumerable()
                    .Select(t => t);
            LB_Progres.Items.Clear();
            foreach (var i in q)
            { LB_Progres.Items.Add(i.Field<int>("Id_student") + "   " + i.Field<string>("FIO"));      }
            
        }

        private void RB_group_CheckedChanged(object sender, EventArgs e)
        {
            
            DataSet ds = new DataSet();
            typ = false;
            LB_Progres.Items.Clear();
            da2.Fill(ds, "Peopl");
            DataTable dt2 = ds.Tables["Peopl"];
            var q = dt2.AsEnumerable()
                    .Select(t => t);
            LB_Progres.Items.Clear();
            foreach (var i in q)
            { LB_Progres.Items.Add(i.Field<int>("Id_group") + "   " + i.Field<string>("name_group")); }


        }
       
        private void B_Prog_grah_Click(object sender, EventArgs e)
        {
            LB_Progres_rez.Items.Clear();
            int sub = 0;
            foreach (Control control in GB_Prog_Sub.Controls)
            {
                if (control is RadioButton)
                    if (((RadioButton)control).Checked)
                    {
                        sub = int.Parse(control.Tag.ToString());                       
                    }
            }

            string line = LB_Progres.SelectedItem.ToString();
            string[] str = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int t = Convert.ToInt32(str[0]);
            string name = str[1];
            string mount = CB_Rez_Date.SelectedItem.ToString();
           string data= sys.Trans(t, PB_progres, sub,LB_Progres_rez, typ, name,mount );

            Save_Rez oc = new Save_Rez();
            oc.ShowDialog();
            if (oc.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                SaveFileDialog sve = new SaveFileDialog();
                if (sve.ShowDialog() == DialogResult.OK)
                {
                    namesave = sve.FileName;
                    stp.SavePDF(PB_progres, namesave, data);
                }

                else { }
            }
            

        }

        private void LB_Progres_Click(object sender, EventArgs e)
        {
            foreach (Control control in GB_Prog_Sub.Controls)
            {
                if (control is RadioButton)
                    if (((RadioButton)control).Checked)
                    {
                        B_Prog_grah.Enabled = true;
                    }
            }


            
        }

        private void GB_Progress_Enter(object sender, EventArgs e)
        {

        }

        private void Progress_Load(object sender, EventArgs e)
        {
              
        }

    }
}
