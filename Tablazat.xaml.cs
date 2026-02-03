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
    /// Interaction logic for Tablazat.xaml
    /// </summary>
    public partial class Tablazat : Window
    {
        public Tablazat()
        {

            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Dictionary<string, int> kontrak = new Dictionary<string, int>
            {
               {"kontra",2 },
                {"Rekontra",4 },
                {"Szubkontra",8 },
                {"Hírskontra",16 },
                {"Mordkontra",32 },
                {"fedáksárikontra",64 },
                {"kismalac",128 },
            };
            
        }

    }
}
