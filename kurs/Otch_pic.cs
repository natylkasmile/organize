using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace kurs
{
    class Otch_pic
    {
        public void Drow(PictureBox pb, int[] point, int[] dat, int coun)
        {
            int[] mar = new int[coun];
            int[] date = new int[coun];
            for (int i = 0; i < coun; i++)
            {
                mar[i] = point[i];
                date[i] = dat[i];
            }
            
            int maxX = 30;
            int maxY = 5;

            Bitmap bmp = new Bitmap(pb.Width, pb.Height);
            Graphics gr = Graphics.FromImage(bmp);

            float cdx = (pb.Width - 90) / maxX;
            float cdy = (pb.Height - 50) / maxY;
            int step = ((int)pb.Height - 60) / maxY;
            int yy = (int)pb.Height - 25;

            Pen p = new Pen(Brushes.Black, 3);
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            //Оси кординат
            gr.DrawLine(p, (int)(0 * cdx) + 25, (int)pb.Height - 25, (int)(0 * cdx) + 25, 0); //ось У
            gr.DrawLine(p, 0, (int)(pb.Height - 30), (int)pb.Width - 25, (int)(pb.Height - 30)); //ось Х, начало в (.) 25+cdx
            //сетка и подписи к осям
            //все работает
            for (float x = 0; x <= maxX + 1; x++)
            {
                gr.DrawString(x.ToString(), new Font("Arial", 8), Brushes.Black, (int)(x * cdx) + 25, pb.Height - 25);
                gr.DrawLine(Pens.Black, (int)(x * cdx) + 25, (int)pb.Height - 25, (int)(x * cdx) + 25, 0);
            }
            for (float y = 1; y <= maxY + 1; y++)
            {
                gr.DrawString((y - 1).ToString(), new Font("Arial", 8), Brushes.Black, (0 * cdx) + 15, (int)(pb.Height - (y) * cdy));
                gr.DrawLine(Pens.Black, 15, (int)(pb.Height - 25 - cdy * (y)), pb.Width - 15, (int)(pb.Height - 25 - cdy * (y)));
            }
            //график



            for (int j = 1; j < date.Length; j++)
            {
                gr.DrawLine(new Pen(Brushes.Black, 2), (int)(date[j - 1] * cdx) + 25, (int)(yy - mar[j - 1] * cdy), (int)(date[j] * cdx) + 25, (int)(yy - mar[j] * cdy));

                gr.FillEllipse(Brushes.Red, (int)(date[j] * cdx) + 23, (int)(yy - 5 - mar[j] * cdy), 8, 8);
            }
            gr.FillEllipse(Brushes.Red, (int)(date[0] * cdx + 23), (int)(yy - 5 - mar[0] * cdy), 8, 8);


            pb.Image = bmp;

        
        }
    }
}
