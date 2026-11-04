using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Btn_Custom_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Twój login: {l.Text}");
        }
    }
}