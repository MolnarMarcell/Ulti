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

        private void InfoButton_MouseEnter(object sender, MouseEventArgs e)
        {
            InfoImage.Visibility = Visibility.Visible;
        }

        private void InfoButton_MouseLeave(object sender, MouseEventArgs e)
        {
            InfoImage.Visibility = Visibility.Collapsed;
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A gomb működik 👍");
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            InfoImage.Visibility = Visibility.Visible;
        }
    }
}
