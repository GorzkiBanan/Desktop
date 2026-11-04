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
        /* LEKCJA
            private string VLogin { get; set; }
            private string VPassword { get; set; }
        */
        public MainWindow()
        {
            InitializeComponent();

            /* LEKCJA 
                DataContext = this;
            */
        }

        public void Btn_Custom_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Twój login to: {l.Text}");

            /* LEKCJA 
                MessageBox.Show("Twój login to: " + this.VLogin);
            */
        }
    }
}