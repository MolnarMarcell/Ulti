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
        //játékosok lista generálása
        public List<string> jatekosok = new List<string>();
        public MainWindow()
        {

            InitializeComponent();
            
        }



        private void OKGOMB_Click(object sender, RoutedEventArgs e)
        {
            //üres mezők kezelése
            if (string.IsNullOrEmpty(elso.Text) || string.IsNullOrEmpty(masodik.Text) || string.IsNullOrEmpty(harmadik.Text) || string.IsNullOrEmpty(negyedik.Text))
            {
                //Hiba üzenet
                MessageBox.Show("Kérem töltse ki az összes mezőt!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error); 
            }
            Jatek jatekwindow = new Jatek();
            // név eggyezés kezelése
            jatekosok.Add(elso.Text);
            //2. jatekos
            if (masodik.Text == elso.Text || masodik.Text == harmadik.Text || masodik.Text == negyedik.Text)
                {
                    MessageBox.Show("A második játékos név megeggyezik az első játékos nevével.\t Adjon meg egy másikat!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            else
                {
                    jatekosok.Add(masodik.Text);
                }
            //3. jatekos
            if (harmadik.Text == elso.Text || harmadik.Text == masodik.Text || harmadik.Text == negyedik.Text)
            {
                MessageBox.Show("A második játékos név megeggyezik a harmadik játékos nevével.\t Adjon meg egy másikat!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                jatekosok.Add(harmadik.Text);
            }
            //4. jatekos
            if (negyedik.Text == elso.Text || negyedik.Text == masodik.Text || negyedik.Text == harmadik.Text)
            {
                MessageBox.Show("A negyedik játékos név megeggyezik egy másik játékos nevével.\t Adjon meg egy másikat!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                jatekosok.Add(negyedik.Text);
            }
            //ha a lista hossza 4(minden játékos megvan) akkor adja tovább a következő ablaknak
            if(jatekosok.Count() == 4) 
            {
                Application.Current.MainWindow = jatekwindow;
                jatekwindow.Betoltes(jatekosok);
                jatekwindow.Show();
                this.Close();
            }
            else
            {
                jatekosok.Clear();
            }
                
            
                
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}