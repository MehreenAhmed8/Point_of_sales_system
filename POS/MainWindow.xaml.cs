using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using POS.Items;
using POS.Model;
using POS.Database;
namespace POS
{
    public partial class MainWindow : Window
    {
        public MainWindow() 
        {
            InitializeComponent();
        }
        private void Fruits_Click(object sender, RoutedEventArgs e)
        {
            F1.Content = new Fruits();   
        }
        private void Drinks_Click(object sender, RoutedEventArgs e)
        {
            F1.Content = new Drinks();
        }

        private void Burgers_Click(object sender, RoutedEventArgs e)
        {
            F1.Content = new Burgers();
        }

        private void Desi_Click(object sender, RoutedEventArgs e)
        {
            F1.Content = new Desi();
        }

        private void Chinese_Click(object sender, RoutedEventArgs e)
        {
            F1.Content = new Chinese();
        }

        private void Naan_Click(object sender, RoutedEventArgs e)
        {
            F1.Content = new Naan();
        }

        private void Sweets_Click(object sender, RoutedEventArgs e)
        {
            F1.Content = new Sweets();
        }

        private void Vegetable_Click(object sender, RoutedEventArgs e)
        {
            F1.Content = new Vegetables();
            
        }

        private void Deserts_Click(object sender, RoutedEventArgs e)
        {
            F1.Content = new Deserts();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
             
            if (datagrid.SelectedIndex >= 0)
            {
                bool flag = false;
                Item row = datagrid.SelectedItem as Item;
                TextBlock rate = datagrid.Columns[1].GetCellContent(row) as TextBlock;
                TextBlock quantity = datagrid.Columns[2].GetCellContent(row) as TextBlock;
                TextBlock total = datagrid.Columns[3].GetCellContent(row) as TextBlock;
                if (quantity.Text.ToString() == "1")
                {
                    datagrid.Items.Remove(row);
                    flag = true;
                 }
                else
                {
                    int q = Convert.ToInt32(quantity.Text);
                    q = q - 1;
                    quantity.Text = q.ToString();
                    int Total = Convert.ToInt32(total.Text);
                    int Price = Convert.ToInt32(rate.Text);
                    total.Text = (Total - Price).ToString();
                       
                }
                HelperClass.DeleteValue(rate.Text.ToString());
                if(flag==true)
                {
                    tax.Content = "0%";
                }
             
            }

        }
        
        private void Print_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (datagrid.Items.Count == 0)
                {
                    MessageBox.Show("Add Items to generate pdf");
                }
                else
                {

                    dB.AddDataGrid(datagrid, total.Content.ToString());
                    Pdf.SaveToPdf(datagrid, subtotal.Content.ToString(),
                       discount.Content.ToString(), tax.Content.ToString(),
                       total.Content.ToString());
                       datagrid.Items.Clear();
                       subtotal.Content = "0";
                       discount.Content = "0";
                       tax.Content = "0";
                       total.Content = "0";
                     MessageBox.Show("pdf sucessfully generated at bin/debug folder ");
                }
            }
            catch(Exception )
            {
                MessageBox.Show("cannot generate pdf");
            }
            finally
                {
                HelperClass.SubTotal = 0;
                }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            HelperClass.SubTotal = 0;
            datagrid.Items.Clear();
            subtotal.Content = "0";
            discount.Content = "0";
            tax.Content = "0";
            total.Content = "0";
        }
    }
}
