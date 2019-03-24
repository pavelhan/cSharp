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

namespace CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Converter converter = new Converter();
            foreach (var item in converter.currencyList)
            {
                currency1.Items.Add(item);
                currency2.Items.Add(item);
            }                       
        }

        private void ComboBox1_Selected(object sender, RoutedEventArgs e)
        {
            currency1 = (ComboBox)sender;            
            ComboBoxItem selectedItem = (ComboBoxItem)currency1.SelectedItem;
            MessageBox.Show(selectedItem.Content.ToString());
        }

        private void ComboBox2_Selected(object sender, RoutedEventArgs e) 
        {
            currency2 = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)currency2.SelectedItem;
            MessageBox.Show(selectedItem.Content.ToString());
        }
    }

}
