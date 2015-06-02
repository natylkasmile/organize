using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp;
using System.IO;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.Drawing;

using System.Threading.Tasks;

namespace kurs
{
    class SaveToPDF
    {
        public void SavePDF(PictureBox pb, string name, string inf)
        {

            string tit = inf;
            var doc = new Document();
            BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\ARIAL.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            PdfWriter.GetInstance(doc, new FileStream(name, FileMode.Create));
            doc.Open();
                      

            iTextSharp.text.Phrase j = new Phrase("График успеваемости",
            new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));

            Paragraph l = new Paragraph(j);
            l.Alignment = Element.ALIGN_CENTER;

            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(pb.Image, BaseColor.WHITE);
         
            
            doc.Add(l);

            iTextSharp.text.Phrase j1 = new Phrase(tit,
new iTextSharp.text.Font(baseFont, 11, iTextSharp.text.Font.BOLD, new BaseColor(Color.Black)));

            Paragraph l1 = new Paragraph(j1);
            l1.Alignment = Element.ALIGN_CENTER;
            doc.Add(l1);


            doc.Add(jpg);


            doc.Close();
            MessageBox.Show("Сохранение завершено");
        }

    }
}
