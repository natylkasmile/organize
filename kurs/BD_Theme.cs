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
    public partial class BD_Theme : Form
    {
        public BD_Theme()
        {
            InitializeComponent();
        }
         DCDataContext dt = new DCDataContext();
                
        private void B_ADD_BDTheme_Click(object sender, EventArgs e)
        {
            Theme th = new Theme()
            {
                name_theme = TB_BDTheme_name.Text
            };
            dt.Theme.InsertOnSubmit(th);
            dt.SubmitChanges();
            dt = new DCDataContext();
            GV_BDTheme.DataSource = dt.Theme;
        }

        private void B_EDIT_BDTheme_Click(object sender, EventArgs e)
        {
            var gr = dt.Theme.Single(rec => rec.Id_theme == Convert.ToInt32(GV_BDTheme.SelectedCells[0].Value));
            gr.name_theme = TB_BDTheme_name.Text;
            dt.SubmitChanges();
            GV_BDTheme.DataSource = dt.Theme;
        }

        private void B_DEL_BDTheme_Click(object sender, EventArgs e)
        {
            ok_candel oc = new ok_candel();
            oc.ShowDialog();
            if (oc.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dt.Theme.DeleteOnSubmit(dt.Theme.Where(elem => elem.Id_theme == Convert.ToInt32(GV_BDTheme.SelectedCells[0].Value)).FirstOrDefault());
                dt.SubmitChanges();
                dt = new DCDataContext();
                GV_BDTheme.DataSource = dt.Theme;
            }

            else { }
        }

        private void BD_Theme_Load(object sender, EventArgs e)
        {
            GV_BDTheme.DataSource = dt.Theme;
        }

        private void GV_BDTheme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_BDTheme_name.Text = (GV_BDTheme.SelectedCells[1].Value).ToString();            
        }
    }
}
