using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Ulti
{
    public partial class Jatek : Window
    {
        int aktualisKor = 1;
        Dictionary<string, int> jatekosPontok = new Dictionary<string, int>();


        // ===== BEMONDÁSOK =====
        public Dictionary<string, int> Bemondasok = new Dictionary<string, int>
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
            {"Piros Ulti 20-100" ,24},
            {"Terített Durchmarsch" ,24},
            {"Piros Durchmarsch 40-100 Ulti" ,28},
            {"Piros Durchmarsch 20-100" ,28},
            {"Terített Durchmarsch 40-100" ,28},
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

        // ===== KONSTRUKTOR =====
        public Jatek()
        {
            InitializeComponent();
            Bemondasok_Betoltes();
        }


        // ===== JÁTÉKOSOK =====
        public void Betoltes(List<string> lista)
        {
            Jatekosok_Combobox.Items.Clear();
            jatekosPontok.Clear();

            foreach (var jatekos in lista)
            {
                Jatekosok_Combobox.Items.Add(jatekos);
                jatekosPontok[jatekos] = 0;
            }

            if (Jatekosok_Combobox.Items.Count > 0)
                Jatekosok_Combobox.SelectedIndex = 0;

            FrissitJatekosPontok();
        }


        private void KorInditas_Click(object sender, RoutedEventArgs e)
        {
            aktualisKor++;

            // Fejléc frissítése
            Border mainBorder = Content as Border; // ez a fő border, 1 db childja lehet, lekéri az összes contentjét a bordernek
            Grid mainGrid = mainBorder.Child as Grid;// ez a fő grid, ez a childja a mainBordernek, és ez 3 childot tartalmaz

            // fejléc grid (Row 0)
            Grid headerGrid = mainGrid.Children[0] as Grid; // ez a header grid, ez a mainGrid első childja

            // bal oldali StackPanel
            StackPanel headerPanel = headerGrid.Children[0] as StackPanel; // ez a headerpanel.

            // "Aktuális kör" TextBlock
            TextBlock korText = headerPanel.Children[1] as TextBlock; // ez a korText, ez mutatja az aktuális kört

            KorText.Text = $"Aktuális kör: {aktualisKor}";



            Bemondas_ComboBox.SelectedIndex = -1;
            Pontszam.Content = "Pont: 0";
        }


        // ===== BEMONDÁSOK =====
        public void Bemondasok_Betoltes()
        {
            Bemondas_ComboBox.Items.Clear();

            foreach (var item in Bemondasok.Keys)
                Bemondas_ComboBox.Items.Add(item);

            Bemondas_ComboBox.SelectionChanged += Bemondas_ComboBox_SelectionChanged;
        }

        // ===== PONTOZÁS =====
        private void Bemondas_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Bemondas_ComboBox.SelectedItem == null)
                return;

            string valasztottBemondas = Bemondas_ComboBox.SelectedItem.ToString();

            if (Bemondasok.TryGetValue(valasztottBemondas, out int pont))
            {
                Pontszam.Content = $"Pont: {pont}";
            }
        }

        private void Pontozas_Click(object sender, RoutedEventArgs e)
        {
            if (Jatekosok_Combobox.SelectedItem == null ||
                Bemondas_ComboBox.SelectedItem == null)
            {
                MessageBox.Show("Válassz játékost és bemondást!");
                return;
            }

            string jatekos = Jatekosok_Combobox.SelectedItem.ToString();
            string bemondas = Bemondas_ComboBox.SelectedItem.ToString();

            int pont = Bemondasok[bemondas];
            jatekosPontok[jatekos] += pont;

            FrissitJatekosPontok();
        }

        private void FrissitJatekosPontok()
        {
            Border mainBorder = Content as Border;
            Grid mainGrid = mainBorder.Child as Grid;

            Grid jatekosGrid = mainGrid.Children[1] as Grid;

            int i = 0;

            foreach (var pair in jatekosPontok)
            {
                if (i >= jatekosGrid.Children.Count)
                    break;

                Border playerBorder = jatekosGrid.Children[i] as Border;
                StackPanel panel = playerBorder.Child as StackPanel;

                ((TextBlock)panel.Children[0]).Text = pair.Key;
                ((TextBlock)panel.Children[1]).Text = $"Pont: {pair.Value}";

                i++;
            }
        }



        // ===== ABLAK KEZELÉS =====
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
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
