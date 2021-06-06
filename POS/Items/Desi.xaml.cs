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
    /// Interaction logic for Desi.xaml
    /// </summary>
    public partial class Desi : Page
    {
        public Desi()
        {
            InitializeComponent();
        }

        private void BBQ_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("BBQ(1Kg)", "500", "500");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "BBQ(1Kg)", 500);
            if (!flag)
            {
                HelperClass.updateValue("500");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }

        }

        private void Biryani_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Biryani(Full)", "250", "250");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Biryani(Full)", 250);
            if (!flag)
            {
                HelperClass.updateValue("250");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void ChickenCurry_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Chicken Curry", "150", "150");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Chicken Curry", 150);
            if (!flag)
            {
                HelperClass.updateValue("150");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void SiriPaye_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Siri Paye", "500", "500");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Siri Paye", 500);
            if (!flag)
            {
                HelperClass.updateValue("500");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }
    }
}
