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
    /// Interaction logic for Drinks.xaml
    /// </summary>
    public partial class Drinks : Page
    {
        public Drinks()
        {
            InitializeComponent();
        }

        private void AlmondShake_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Almond Shake", "150", "150");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Almond Shake", 150);
            if (!flag)
            {
                HelperClass.updateValue("150");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void AppleShake_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Apple Shake", "100", "100");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Apple Shake", 100);
            if (!flag)
            {
                HelperClass.updateValue("100");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void CokeRegular_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Coke(Regular)", "25", "25");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Coke(Regular)", 25);
            if (!flag)
            {
                HelperClass.updateValue("25");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void CokeTin_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Coke Tin", "70", "70");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Coke Tin", 70);
            if (!flag)
            {
                HelperClass.updateValue("70");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void SpriteTin_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Sprite Tin", "70", "70");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Sprite Tin", 70);
            if (!flag)
            {
                HelperClass.updateValue("70");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }

        private void StawberryShake_Click(object sender, RoutedEventArgs e)
        {
            Item obj1 = new Item("Stawberry Shake", "150", "150");
            DataGrid x = ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid;
            bool flag = HelperClass.Logic(x, "Stawberry Shake", 150);
            if (!flag)
            {
                HelperClass.updateValue("150");
                ((MainWindow)System.Windows.Application.Current.MainWindow).datagrid.Items.Add(obj1);
            }
        }
    }
}
