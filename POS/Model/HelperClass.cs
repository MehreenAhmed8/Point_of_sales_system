using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using POS.Database;

namespace POS.Model
{
    class HelperClass
    {
        public static int SubTotal=0;
        public static Label subT = ((MainWindow)System.Windows.Application.Current.MainWindow).subtotal;
        public static Label dis = ((MainWindow)System.Windows.Application.Current.MainWindow).discount;
        public static Label tax = ((MainWindow)System.Windows.Application.Current.MainWindow).tax;
        public static Label total = ((MainWindow)System.Windows.Application.Current.MainWindow).total;
        public static bool Logic(DataGrid x, string name, int rate)
           {
            
             for (int i = 0; i < x.Items.Count; i++)
            {
               
               DataGridRow row = (DataGridRow)x.ItemContainerGenerator.ContainerFromIndex(i);     
               TextBlock cellContent = x.Columns[0].GetCellContent(row) as TextBlock;
                    if ((cellContent.Text) == name)
                    {
                    TextBlock price = x.Columns[1].GetCellContent(row) as TextBlock;
                    TextBlock quantity = x.Columns[2].GetCellContent(row) as TextBlock;
                        TextBlock total = x.Columns[3].GetCellContent(row) as TextBlock;
                        int q = Convert.ToInt32(quantity.Text);
                        q++;
                        quantity.Text = q.ToString();
                        total.Text = (q * rate).ToString();
                        updateValue(price.Text.ToString());
                    return true;
                    }
                
            }
            return false;
        }

        public static void updateValue(string total1)
        {
            Double disT = 0, Tax = 0;
            SubTotal += Convert.ToInt32(total1); 
            subT.Content = SubTotal.ToString();


            if(SubTotal>5000)
            {
                disT = 0.2* SubTotal;
                dis.Content = "20%";
            }
            Tax = 0.14 * SubTotal;
            tax.Content = "14%";
            
            Double Total = SubTotal - disT + Tax;
            total.Content = Total.ToString();
            
        }

        public static void DeleteValue(string s )
        {
            Double disT = 0, Tax = 0;
            SubTotal  -= Convert.ToInt32(s);
            subT.Content = SubTotal.ToString();


            if (SubTotal > 5000)
            {
                disT = 0.2 * SubTotal;
                dis.Content = "20%";
                
            }
            else
            {
                disT = 0;
                dis.Content = "0%";
            }
           
            Tax = 0.14 * SubTotal;
            tax.Content = "14%";
            Double Total = SubTotal - disT + Tax;
            total.Content = Total.ToString();
        }
          
        public static List<Data> GetList(DataGrid y)
        {
            List<Data> L1 = new List<Data>();

            for (int i = 0; i < y.Items.Count; i++)
            {

                DataGridRow row = (DataGridRow)y.ItemContainerGenerator.ContainerFromIndex(i);
                      TextBlock Name = y.Columns[0].GetCellContent(row) as TextBlock;
                      TextBlock quantity = y.Columns[2].GetCellContent(row) as TextBlock;
                Data obj1 = new Data(Name.Text.ToString(), quantity.Text.ToString());

                L1.Add(obj1);

            }
            return L1;
        }

    }
}
