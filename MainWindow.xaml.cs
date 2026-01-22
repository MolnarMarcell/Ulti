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

namespace Ulti
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        List<Jatekosok> jatekosoks = new List<Jatekosok>();

        public MainWindow()
        {

            InitializeComponent();
        }



        private void OKGOMB_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(elso.Text) || string.IsNullOrEmpty(masodik.Text) || string.IsNullOrEmpty(harmadik.Text) || string.IsNullOrEmpty(negyedik.Text))
            {
                MessageBox.Show("Kérem töltse ki az összes mezőt!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
                Jatek jatekwindow = new Jatek();

            //
                Jatekosok ujjatekos = new Jatekosok(elso.Text, masodik.Text, harmadik.Text, negyedik.Text);
                jatekosoks.Add(ujjatekos);

                foreach (var sor in jatekosoks)
                {
                    vissza.Content = $"{sor.elsojatekos}, {sor.masodikjatekos}, {sor.harmadikjatekos}, {sor.negyedikjatekos}";
                }

                Application.Current.MainWindow = jatekwindow;
                jatekwindow.Show();

                this.Close();
        }
    }
}