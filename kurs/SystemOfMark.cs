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
    
    class SystemOfMark
    {
        DCDataContext dcdc = new DCDataContext();
       
            
        public string Trans(int id, PictureBox pb, int sub,  ListBox lb, bool typ, string name, string mou)
        {
            string nam = name;
            string mount = mou;
            string itog = "";
            string vivod = "";
            var dateString = "2014-03-01 00:00:00-05:00";
            // парсим день рождения как смещение даты/времени (без конвертирования в локальные даты/время)
            var dtOffset =  DateTimeOffset.Parse(dateString);
            // теперь если нам надо сравнить результат с другими объектами типа локального DateTime
            // мы просто используем свойство Date для получения даты
            // без времени или смещения
            
            var theDay = dtOffset.Date;

            //Enumerable<>   вместо var

            //Enum elem = null;
            if (typ)
            {
                itog = "Студент(ка) " + name + " за " + mount + " месяц"; 
                var elem = from rec in dcdc.Mark
                       where rec.studID == id && rec.subID == sub && rec.date_p > dtOffset
                       orderby rec.date_p
                       select new { point = rec.point, date = rec.date_p.Value.Date.ToShortDateString() };
               int i = 0;
               int coun = elem.Count();
               int[] mar = new int[coun];
               int[] date = new int[coun];
               foreach (var m in elem)
               {
                   mar[i] = Convert.ToInt32(m.point);
                   var t = DateTimeOffset.Parse(m.date).Day;
                   date[i] = Convert.ToInt32(t);
                   i++;
                   vivod += m.ToString() + Environment.NewLine;
               }


               lb.Items.Add(vivod);


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
            else
            {
                itog = "Успеваемость группы " + name + " За " + mount + " месяц"; 
                
                var  elem = from rec in dcdc.Mark
                where rec.subID == sub && rec.date_p > dtOffset &&
                          (from r in dcdc.Student
                          where r.groupID == id
                         select r.Id_student).Contains(rec.studID.Value)
                orderby rec.date_p
                select new { point = rec.point, date = rec.date_p.Value.Date.ToShortDateString() };
               int i = 0;
               int coun = elem.Count();
               int[] mar = new int[coun];
               int[] date = new int[coun];
               foreach (var m in elem)
               {
                   mar[i] = Convert.ToInt32(m.point);
                   var t = DateTimeOffset.Parse(m.date).Day;
                   date[i] = Convert.ToInt32(t);
                   i++;
                   vivod += m.ToString() + Environment.NewLine;
               }


               lb.Items.Add(vivod);


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

            return itog;
                                 
        }

    }
}
