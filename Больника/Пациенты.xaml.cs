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
    /// Логика взаимодействия для Пациенты.xaml
    /// </summary>
    public partial class Пациенты : Window
    {
        public Пациенты()
        {
            InitializeComponent();
            double screenHeight = SystemParameters.FullPrimaryScreenHeight;
            double screenWidth = SystemParameters.FullPrimaryScreenWidth;
            this.Top = (screenHeight - this.Height) / 0x00000002;
            this.Left = (screenWidth - this.Width) / 0x00000002;
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            label_loading.Content = "Выполено";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            СписокПациентов списокпациентов = new СписокПациентов();
            списокпациентов.Show();
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
