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
    /// Interaction logic for Naan.xaml
    /// </summary>
    public partial class Naan : Page
    {
        public Naan()
        {
            InitializeComponent();
        }

        private void CheeseNaan_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Cheese Naan", "100", "100");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Cheese Naan", 100);
            if (!flag)
            {
                HelperClass.updateValue("100");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void RoghniNaan_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Roghni Naan", "25", "25");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Roghni Naan", 25);
            if (!flag)
            {
                HelperClass.updateValue("25");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void SadaNaan_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Sada Naan", "20", "20");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Sada Naan", 20);
            if (!flag)
            {
                HelperClass.updateValue("20");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }
    }
}
