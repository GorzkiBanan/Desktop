using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf2
{
    public partial class MainWindow : Window
    {
        public string txValue { get; set; }
        public int My_int_value { get; set; }

        public ObservableCollection<int> My_Collection { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            this.My_Collection = new ObservableCollection<int>();
            DataContext = this;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
           if(validate_number(this.txValue))
            this.My_Collection.Add(this.My_int_value);
        }

        private bool validate_number(string input)
        {
            var isNumber = int.TryParse(input, out var number);
            this.My_int_value = number;
            return isNumber;
        }
    }
}