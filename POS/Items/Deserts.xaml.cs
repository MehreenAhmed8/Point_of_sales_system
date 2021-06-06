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
    /// Interaction logic for Deserts.xaml
    /// </summary>
    public partial class Deserts : Page
    {
        public Deserts()
        {
            InitializeComponent();
        }

        private void CakeBite_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Cake Bite", "60", "60");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Cake Bite", 60);
            if (!flag)
            {
                HelperClass.updateValue("60");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void CupCake_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Cup Cake", "100", "100");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Cup Cake", 100);
            if (!flag)
            {
                HelperClass.updateValue("100");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }

        }

        private void IceCream_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Ice Cream", "200", "200");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Ice Cream", 200);
            if (!flag)
            {
                HelperClass.updateValue("200");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }

        }

        private void Macroons_Click(object sender, RoutedEventArgs e)
        {
            
            Item obj1 = new Item("Macroons", "100", "100");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Macroons", 100);
            if (!flag)
            {
                HelperClass.updateValue("100");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }
    }
}
