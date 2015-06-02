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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void TS_bDGroup_Click(object sender, EventArgs e)
        {
            BD_Group gr = new BD_Group();
            gr.ShowDialog();

        }

        private void TS_bDLessons_Click(object sender, EventArgs e)
        {
            BD_Lessons les = new BD_Lessons();
            les.ShowDialog();
        }

        private void TS_bDStudent_Click(object sender, EventArgs e)
        {
            BD_Student st = new BD_Student();
            st.ShowDialog();

        }

        private void TS_bDTheme_Click(object sender, EventArgs e)
        {
            BD_Theme th = new BD_Theme();
            th.ShowDialog();
        }

        private void TS_bDSubject_Click(object sender, EventArgs e)
        {
            BD_Subject sub = new BD_Subject();
            sub.ShowDialog();
        }

        private void TS_bDGroupSub_Click(object sender, EventArgs e)
        {
            BD_Group_Sub gs = new BD_Group_Sub();
            gs.ShowDialog();
        }

        private void TS_bDPractice_Click(object sender, EventArgs e)
        {
            BD_Practice pr = new BD_Practice();
            pr.ShowDialog();
        }

        private void TS_bDTheoria_Click(object sender, EventArgs e)
        {
            BD_Theoria teo = new BD_Theoria();
            teo.ShowDialog();
        }

        private void TS_bDMark_Click(object sender, EventArgs e)
        {
            BD_Mark mr = new BD_Mark();
            mr.ShowDialog();
        }

        private void TS_bDSchedule_Click(object sender, EventArgs e)
        {
            BD_Schedule sc = new BD_Schedule();
            sc.ShowDialog();
        }

        private void TS_bDTranslate_Click(object sender, EventArgs e)
        {
            BD_Translate tr = new BD_Translate();
            tr.ShowDialog();
        }

        private void TS_bDTypeQuest_Click(object sender, EventArgs e)
        {
            BD_T_Quest tq = new BD_T_Quest();
            tq.ShowDialog();
        }

        private void TS_bDTypeAnsw_Click(object sender, EventArgs e)
        {
            BD_T_Answ ta = new BD_T_Answ();
            ta.ShowDialog();
        }

        private void TS_Prigress_Click(object sender, EventArgs e)
        {
            Progress pr = new Progress();
            pr.ShowDialog();   
        }

    }
}
