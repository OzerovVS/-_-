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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
            Cars.ItemsSource = nado.b.GetData();
            nado.car_set(Cars);
            for (int i = 0; i < Cars.Items.Count; i++)
            {
                (Cars.Items[i] as DataRowView)[2] = (nado.color_class.Items[i] as DataRowView)[1];
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Hide();
            nado.color_tp();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            nado.creater_tp();
        }
    }
}