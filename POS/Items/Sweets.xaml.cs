using POS.Model;
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

namespace POS.Items
{
    /// <summary>
    /// Interaction logic for Sweets.xaml
    /// </summary>
    public partial class Sweets : Page
    {
        public Sweets()
        {
            InitializeComponent();
        }

        private void Barfi_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Barfi(1Kg)", "500", "500");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Barfi(1Kg)", 500);
            if (!flag)
            {
                HelperClass.updateValue("500");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void GulanJamun_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Gulab Jamun(1Kg)", "300", "300");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Gulab Jamun(1Kg)", 300);
            if (!flag)
            {
                HelperClass.updateValue("300");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void Jalebi_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Jalebi(1Kg)", "300", "300");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Jalebi(1Kg)", 300);
            if (!flag)
            {
                HelperClass.updateValue("300");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void Patisa_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Patisa(1Kg)", "350", "350");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Patisa(1Kg)", 350);
            if (!flag)
            {
                HelperClass.updateValue("350");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void Rasgullah_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Rasgulla(1Kg)", "400", "400");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Rasgulla(1Kg)", 400);
            if (!flag)
            {
                HelperClass.updateValue("400");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void Rasmalai_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Ras Malai(1Kg)", "150", "150");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Ras Malai(1Kg)", 150);
            if (!flag)
            {
                HelperClass.updateValue("150");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }
    }
}
