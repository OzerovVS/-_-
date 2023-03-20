using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
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

using практика_резня.car_dbDataSetTableAdapters;

namespace практика_резня
{
    class nado
    {
        static public DataGrid color_class { get; set; }
        static public DataGrid car_class { get; set; }
        static public DataGrid creater_class { get; set; }
        static public colorTableAdapter a = new colorTableAdapter();
        static public carTableAdapter b = new carTableAdapter();
        static public createrTableAdapter c = new createrTableAdapter();
        static public void color_set(DataGrid a)
        {
            color_class = a;
        }
        static public void car_set(DataGrid a)
        {
            car_class = a;
        }
        static public void creater_set(DataGrid a)
        {
            creater_class = a;
        }

        static public void color_tp()
        {
            new MainWindow().Show();
        }
        static public void car_tp()
        {
            new Window1().Show();
        }
        static public void creater_tp()
        {
            new Window2().Show();
        }

    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Colors.ItemsSource = nado.a.GetData();
            nado.color_set(Colors);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            nado.car_tp();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Hide();
            nado.creater_tp();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((Colors.Items[0] as DataRowView)[0]).ToString());
        }

        private void Colors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            /*
            MessageBox.Show(Colors.SelectedItem.ToString());
            var g = Colors.SelectedItem;
            nado.a.Delete(Convert.ToInt32((g as DataRowView)[0]), (g as DataRowView)[1].ToString());*/
        }
    }
}
