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
    /// Interaction logic for Chinese.xaml
    /// </summary>
    public partial class Chinese : Page
    {
        public Chinese()
        {
            InitializeComponent();
        }

        private void AlfredoPastaBtn_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Alfredo Pasta", "200", "200");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Alfredo Pasta", 200);
            if (!flag)
            {
                HelperClass.updateValue("200");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void ItalianPastaBtn_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Italian Pasta", "300", "300");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Italian Pasta", 300);
            if (!flag)
            {
                HelperClass.updateValue("300");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void LasagnaBtn_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Lasagna", "500", "500");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Lasagna", 500);
            if (!flag)
            {
                HelperClass.updateValue("500");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void PizzaBtn_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item(" Pizza", "1000", "1000");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, " Pizza", 1000);
            if (!flag)
            {
                HelperClass.updateValue("1000");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void TortelliniBtn_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Tortellini", "1000", "1000");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Tortellini", 1000);
            if (!flag)
            {
                HelperClass.updateValue("1000");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }
    }
}
