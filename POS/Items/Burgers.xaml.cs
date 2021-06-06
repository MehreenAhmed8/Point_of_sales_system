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
using POS.Model;

namespace POS.Items
{
    /// <summary>
    /// Interaction logic for Burgers.xaml
    /// </summary>
    public partial class Burgers : Page
    {
        public Burgers()
        {
            InitializeComponent();
        }

        private void BBQBurgerbtn_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("BBQ Burger", "600", "600");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "BBQ Burger", 600);
            if (!flag)
            {
                HelperClass.updateValue("700");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }

        }

        private void PiriPiriBugerbtn_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Piri Piri Burger", "800", "800");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Piri Piri Burger", 800);
            if (!flag)
            {
                HelperClass.updateValue("800");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }

        }

        private void ZingerBurgerbtn_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Zinger Burger", "300", "300");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Zinger Burger", 300);
            if (!flag)
            {
                HelperClass.updateValue("300");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }

        }

        private void CheeseBurgerbtn_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Cheese Burger", "350", "350");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Cheese Burger", 350);
            if (!flag)
            {
                HelperClass.updateValue("350");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }

        }

        private void LavaCheeseBurgerBtn_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Lava Cheese Burger", "550", "550");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Lava Cheese Burger", 550);
            if (!flag)
            {
                HelperClass.updateValue("550");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void HamBurgerBtn_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Ham Burger", "500", "500");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Ham Burger", 500);
            if (!flag)
            {
                HelperClass.updateValue("500");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }
    }
}
