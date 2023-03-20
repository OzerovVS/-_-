using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace практика_резня
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            Creater.ItemsSource = nado.c.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            nado.color_tp();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Hide();
            nado.car_tp();
        }

        private void Creater_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            nado.c.DeleteQuery(Convert.ToInt32((Creater.SelectedItem as DataRowView).Row[0]), ((Creater.SelectedItem as DataRowView).Row[1]).ToString(), Convert.ToInt32((Creater.SelectedItem as DataRowView).Row[2]));
        }
    }
}
