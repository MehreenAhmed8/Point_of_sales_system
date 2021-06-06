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
    /// Interaction logic for Fruits.xaml
    /// </summary>
    public partial class Fruits : Page
    {
        public Fruits()
        {
            InitializeComponent();
        }

        private void Apple_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Apple(1Kg)", "100", "100");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Apple(1Kg)", 100);
            if (!flag)
            {
                 HelperClass.updateValue("100");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void Watermelon_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Watermelon(1Kg)", "100", "100");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Watermelon(1Kg)", 100);
            if (!flag)
            {
                HelperClass.updateValue("100");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void Peach_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Peach(1Kg)", "70", "70");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Peach(1Kg)", 70);
            if (!flag)
            {
                HelperClass.updateValue("70");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void Orange_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Orange(1Kg)", "60", "60");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Orange(1Kg)", 60);
            if (!flag)
            {
                HelperClass.updateValue("60");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void Mango_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Mango(1Kg)", "150", "150");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Mango(1Kg)", 150);
            if (!flag)
            {
                HelperClass.updateValue("150");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void Grapes_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Grapes(1Kg)", "100", "100");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Grapes(1Kg)", 100);
            if (!flag)
            {
                HelperClass.updateValue("100");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void Banana_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Banana(1Kg)", "150", "150");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Banana(1Kg)", 150);
            if (!flag)
            {
                HelperClass.updateValue("150");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }
    }
}
