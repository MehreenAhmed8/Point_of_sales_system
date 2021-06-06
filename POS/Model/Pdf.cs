using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;

using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Graphics.Fonts;
using Spire.Pdf.Tables;


namespace POS.Model
{
    class Pdf
    {

        public static void SaveToPdf( DataGrid x , String subTotal , String discount , String tax , String Total)
        {

            //create a new PDF document
            PdfDocument doc = new PdfDocument();
            PdfUnitConvertor unitCvtr = new PdfUnitConvertor();
            PdfMargins margin = new PdfMargins();
            margin.Top = unitCvtr.ConvertUnits(2.54f, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
            margin.Bottom = margin.Top;
            margin.Left = unitCvtr.ConvertUnits(3.17f, PdfGraphicsUnit.Centimeter, PdfGraphicsUnit.Point);
            margin.Right = margin.Left;
            PdfPageBase page = doc.Pages.Add(PdfPageSize.A4, margin);
            float y = 20;
            //add PDF title
            PdfBrush brush1 = PdfBrushes.Black;
            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Verdana", 14f, System.Drawing.FontStyle.Regular));
            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);
            page.Canvas.DrawString(" SubTotal : "+subTotal+"\t \t Discount : "+discount+"\n Tax :"+tax +"\t \t \tTotal : "+Total , font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);
            y = y + font1.MeasureString("Your Order Reciept ", format1).Height;
            y = y + 20;
            //add data information
            String []data1 = new String[x.Items.Count+1];
            data1[0] = "Item;Price;Quantity;total";

            for (int i = 0 , c=1; i < x.Items.Count; i++,c++)
            {

                DataGridRow row = (DataGridRow)x.ItemContainerGenerator.ContainerFromIndex(i);
                TextBlock Item = x.Columns[0].GetCellContent(row) as TextBlock;
                TextBlock Price = x.Columns[1].GetCellContent(row) as TextBlock;
                TextBlock Qty = x.Columns[2].GetCellContent(row) as TextBlock;
                TextBlock total = x.Columns[3].GetCellContent(row) as TextBlock;

                data1[c] = Item.Text.ToString() + ";" + Price.Text.ToString() + ";" + Qty.Text.ToString() + ";" + total.Text.ToString() ;
            }

            String[][] dataSource
                = new String[data1.Length][];
            for (int i = 0; i < data1.Length; i++)
            {
                dataSource[i] = data1[i].Split(';');
            }

            
            //Set table header
            PdfTable table = new PdfTable();
            table.Style.CellPadding = 3;
            table.Style.HeaderSource = PdfHeaderSource.Rows;
            table.Style.HeaderRowCount = 1;
            table.DataSource = dataSource;
            table.Style.ShowHeader = true;

            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.LightSeaGreen;
            table.Style.HeaderStyle.Font = new PdfTrueTypeFont(new Font("Verdana", 9f, System.Drawing.FontStyle.Bold));
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.HeaderStyle.TextBrush = PdfBrushes.White;

            //Set table style and data format
            table.Style.BorderPen = new PdfPen(PdfBrushes.LightBlue, 0.5f);
            table.Style.DefaultStyle.BackgroundBrush = PdfBrushes.LightYellow;
            table.Style.DefaultStyle.Font = new PdfTrueTypeFont(new Font("Verdana", 8.5f));
            table.Style.AlternateStyle = new PdfCellStyle();
            table.Style.AlternateStyle.BackgroundBrush = PdfBrushes.AliceBlue;
            table.Style.AlternateStyle.Font = new PdfTrueTypeFont(new Font("Verdana", 8.5f));

            float width
                = page.Canvas.ClientSize.Width
                - (table.Columns.Count + 1) * table.Style.BorderPen.Width;
            table.Columns[0].Width = width * 0.1f * width;
            table.Columns[0].StringFormat
                = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);

            table.Columns[1].Width = width * 0.28f * width;
            table.Columns[1].StringFormat
                = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            table.Columns[2].Width = width * 0.1f * width;
            table.Columns[2].StringFormat
                = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            table.Columns[3].Width = width * 0.1f * width;
            table.Columns[3].StringFormat
                = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
          
            PdfLayoutResult result = table.Draw(page, new PointF(0, y));
            doc.SaveToFile((DateTime.Now.ToString("yyyy_MM_dd ;; hh_mm_ss"))+".pdf");
            doc.Close();
            //System.Diagnostics.Process.Start(now.ToString()+".pdf");

        }

    }
}
