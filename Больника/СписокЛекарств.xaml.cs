﻿using System;
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
    /// Логика взаимодействия для СписокЛекарств.xaml
    /// </summary>
    public partial class СписокЛекарств : Window
    {
        public СписокЛекарств()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow основное = new MainWindow();
            основное.Show();
            this.Close();
        }
    }
}
