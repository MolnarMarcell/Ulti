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

namespace Ulti
{
    /// <summary>
    /// Interaction logic for Jatek.xaml
    /// </summary>
    public partial class Jatek : Window
    {
        public Jatek()
        {
            InitializeComponent();
        }

        private void Checking(object sender, RoutedEventArgs e)
        {
            

            if (Passz.IsChecked == true)
            {
                Bug_fix.Content = "Passz kiválasztva";
            }
            if (_40_100.IsChecked == true)
            {
                Bug_fix.Content = "40-100 kiválasztva";
            }
            if (Ulti.IsChecked == true)
            {
                Bug_fix.Content = "Ulti kiválasztva";
            }
            if (Ulti.IsChecked == true)
            {
                Bug_fix.Content = "Ulti kiválasztva";
            }
            if (Ulti.IsChecked == true)
            {
                Bug_fix.Content = "Ulti kiválasztva";
            }


        }
    }
}
