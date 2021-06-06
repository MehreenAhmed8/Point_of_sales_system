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
    /// Interaction logic for Vegetables.xaml
    /// </summary>
    public partial class Vegetables : Page
    {
        public Vegetables()
        {
            InitializeComponent();
        }

        private void Cabbage_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Cabbage(1Kg)", "50", "50");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Cabbage(1Kg)", 50);
            if (!flag)
            {
                HelperClass.updateValue("50");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void Dhaniya_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Dhaniya", "10", "10");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Dhaniya", 10);
            if (!flag)
            {
                HelperClass.updateValue("10");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void GreenChilli_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Green Chilli(500g)", "30", "30");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "GreenChilli", 30);
            if (!flag)
            {
                HelperClass.updateValue("30");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void LadyFinger_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Lady Finger(1Kg)", "100", "100");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Lady Finger(1Kg)", 100);
            if (!flag)
            {
                HelperClass.updateValue("100");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void Onion_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Onion(1Kg)", "150", "150");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Onion(1Kg)", 150);
            if (!flag)
            {
                HelperClass.updateValue("150");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void Potato_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Potato(1Kg)", "40", "40");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Potato(1Kg)", 40);
            if (!flag)
            {
                HelperClass.updateValue("40");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void RedChilli_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Red Chilli(500g)", "50", "50");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Red Chilli(500g)", 50);
            if (!flag)
            {
                HelperClass.updateValue("50");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void Tomato_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Tomato(1Kg)", "150", "150");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Tomato(1Kg)", 150);
            if (!flag)
            {
                HelperClass.updateValue("150");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }
    }
}
