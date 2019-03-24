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

namespace MyWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        int clickCount = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            switch (clickCount)
            {
                case 1:
                    label1.Background = Brushes.Red;
                    label9.Background = Brushes.White;
                    break;
                case 2:
                    label2.Background = Brushes.Blue;
                    label1.Background = Brushes.White;
                    break;
                case 3:
                    label3.Background = Brushes.Green;
                    label2.Background = Brushes.White;
                    break;
                case 4:
                    label4.Background = Brushes.RosyBrown;
                    label3.Background = Brushes.White;
                    break;
                case 5:
                    label6.Background = Brushes.Gray;
                    label4.Background = Brushes.White;
                    break;
                case 6:
                    label7.Background = Brushes.Gold;
                    label6.Background = Brushes.White;
                    break;
                case 7:
                    label8.Background = Brushes.Ivory;
                    label7.Background = Brushes.White;
                    break;
                case 8:
                    label9.Background = Brushes.Khaki;
                    label8.Background = Brushes.White;
                    break;

            }
                 
            clickCount++;
            if(clickCount == 9)
            {
                clickCount = 1;                
            }
        }
    }
}
    

