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
        public List<string> jatekosok = new List<string>();
        //public MainWindow(List<string> jatekosok)
        //{
        //    InitializeComponent();
        //    this.jatekosok = jatekosok;
        //    Jatekosok_Combobox = jatekosok;
        //}


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
            jatekosok.Add(elso.Text);
            jatekosok.Add(masodik.Text);
            jatekosok.Add(harmadik.Text);
            jatekosok.Add(negyedik.Text);
            

                Application.Current.MainWindow = jatekwindow;
                jatekwindow.Betoltes(jatekosok);
                jatekwindow.Show();

                this.Close();
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