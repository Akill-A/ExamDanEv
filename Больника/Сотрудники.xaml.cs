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
using System.Windows.Shapes;

namespace Программа_Больника
{
    /// <summary>
    /// Логика взаимодействия для Сотрудники.xaml
    /// </summary>
    public partial class Сотрудники : Window
    {
        public Сотрудники()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow основное = new MainWindow();
            основное.Show();
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow основное = new MainWindow();
            основное.Show();
            this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            label_loading.Content = "Выполено";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            СписокСотрудников списоксотрудников = new СписокСотрудников();
            списоксотрудников.Show();
            this.Close();
        }
    }
}
