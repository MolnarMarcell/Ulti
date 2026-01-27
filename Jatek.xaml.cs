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
        //segéd változók
        bool bemondE = false;
        bool jatekosE = false;
        string BemondasComboBox="";
        string JatekosComboBox="";

        //Játékos nevek betöltése
        public void Betoltes(List<string> lista)
        {
            foreach (var item in lista)
            {
                Jatekosok_Combobox.Items.Add(item);
            }
        }

        //Listából való bemondások betöltése ComboBox-ba
        public void Bemondasok_Betoltes(Dictionary<string, int> lista)
        {
            foreach (var item in lista)
            {
                Bemondas_ComboBox.Items.Add(item.Key);
            }
        }

        //Bemondások listája+pontokkal
        public Dictionary<string,int> Bemondasok = new Dictionary<string, int>
            {
            {"Passz",1 },
            {"Piros Passz",2},
            {"40-100",4 },
            {"Ulti",5 },
            {"Betli",5 },
            {"Durchmarsch",6 },
            {"40-100 Ulti",8 },
            {"Piros 40-100",8},
            {"20-100" ,10},
            {"Piros Ulti" ,10},
            {"Pirosbetli" ,10},
            {"Durchmarsch 40-100" ,10},
            {"Durchmarsch Ulti" ,12},
            {"Ulti 20-100" ,12},
            {"Pirosdurchmarsch" ,14},
            {"Durchmarsch 40-100 Ulti" ,14},
            {"Durchmarsch 20-100" ,16},
            {"Piros 40-100 Ulti" ,16},
            {"Piros 20-100" ,16},
            {"Durchmarsch Ulti 20-100" ,18},
            {"Pirosdurchmarsch 40-100" ,20},
            {"Pirosdurchmarsch Ulti" ,20},
            {"Terítettbetli" ,20},
            { "Piros Ulti 20-100" ,24},
            {"Terített Durchmarsch" ,24},
            {"Piros Durchmarsch 40-100 Ulti" ,28},
            {"Piros Durchmarsch 20-100" ,28},
            {"Terített Durchmarsch 40-100"   ,28},
            {"Terített Durchmarsch Ulti" ,28},
            {"Terített Durchmarsch 40-100 Ulti" ,32},
            {"Piros Terített Durchmarsch 40-100" ,32},
            {"Piros Terített Durchmarsch Ulti" ,32},
            {"Terített Durchmarsch 20-100" ,32},
            {"Piros Durchmarsch Ulti 20-100" ,36},
            {"Terített Durchmarsch Ulti 20-100" ,36},
            {"Piros Terített Durchmarsch 40-100 Ulti" ,40},
            {"Piros Terített Durchmarsch 20-100" ,40},
            {"Piros Terített Durchmarsch Ulti 20-100" ,48}               
            };

        //Játékos + bemondás kiírása, ha nincs kiválasztva semmi, akkor úgymond "hiba" üzenet ad ki
        public void Allapot()
        {
            if (bemondE && jatekosE)
            {
                Allapot_Label.Content = $"{JatekosComboBox} ezt választotta: {BemondasComboBox}";
            }
            else
            {
                Allapot_Label.Content = "Kérem válasszon játékost és bemondást!";
            }
        }

        public Jatek()
        {
            InitializeComponent(); //betöltés kor:
            Betoltes(new List<string>()); //játékosok betöltése
            Bemondasok_Betoltes(Bemondasok); // bemondások betöltése          
        }

        private void Valtozas_ComboBox(object sender, SelectionChangedEventArgs e)
        {
            //Bemondás kiválasztása
            BemondasComboBox = Bemondas_ComboBox.SelectedItem.ToString();
            int pont = Bemondasok[BemondasComboBox];
            Pontszam.Content = pont;
            bemondE=true;
            Allapot();

        }

        private void JatekosE(object sender, SelectionChangedEventArgs e)
        {
            //játékos kiválasztása
            JatekosComboBox = Jatekosok_Combobox.SelectedItem.ToString();
            jatekosE = true;
            Allapot();
        }

        private void Mentes_Gomb_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    }
