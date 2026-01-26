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
        public void Betoltes(List<string> lista)
        {
            foreach (var item in lista)
            {
                Jatekosok_Combobox.Items.Add(item);
            }


        }
        public void Bemondasok_Betoltes(List<string> lista)
        {
            foreach (var item in lista)
            {
                Bemondas_ComboBox.Items.Add(item);
            }
        }
        public List<string> Bemondasok = new List<string>
            {
                "Passz",
                "Piros Passz",
                "40-100",
                "Ulti",
                "Betli",
                "Durchmarsch",
                "40-100 Ulti",
                "Piros 40-100",
                "20-100",
                "Piros Ulti",
                "Pirosbetli",
                "Durchmarsch 40-100",
                "Durchmarsch Ulti",
                "Ulti 20-100",
                "Pirosdurchmarsch",
                "Durchmarsch 40-100 Ulti",
                "Durchmarsch 20-100",
                "Piros 40-100 Ulti",
                "Piros 20-100",
                "Durchmarsch Ulti 20-100",
                "Pirosdurchmarsch 40-100",
                "Pirosdurchmarsch Ulti",
                "Terítettbetli",
                "Piros Ulti 20-100",
                "Terített Durchmarsch",
                "Piros Durchmarsch 40-100 Ulti",
                "Piros Durchmarsch 20-100",
                "Terített Durchmarsch 40-100",
                "Terített Durchmarsch Ulti",
                "Terített Durchmarsch 40-100 Ulti",
                "Piros Terített Durchmarsch 40-100",
                "Piros Terített Durchmarsch Ulti",
                "Terített Durchmarsch 20-100",
                "Piros Durchmarsch Ulti 20-100",
                "Terített Durchmarsch Ulti 20-100",
                "Piros Terített Durchmarsch 40-100 Ulti",
                "Piros Terített Durchmarsch 20-100",
                "Piros Terített Durchmarsch Ulti 20-100",
            };
        

        public Jatek()
        {
            InitializeComponent();
            Betoltes(new List<string>());
            Bemondasok_Betoltes(Bemondasok);
        }

        
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
