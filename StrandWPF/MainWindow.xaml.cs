using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using StrandC; // Hivatkozás a konzolos projektre

namespace StrandWPF
{
    public partial class MainWindow : Window
    {
        private List<Furdo> furdok;
        private const string FajlNev = "strandadatok.txt";

        public MainWindow()
        {
            InitializeComponent();
            furdok = BeolvasStrandAdatok(FajlNev);
            furdoDataGrid.ItemsSource = furdok;
        }

        private List<Furdo> BeolvasStrandAdatok(string fajlnev)
        {
            try
            {
                return File.ReadAllLines(fajlnev)
                           .Skip(1) // Fejléc kihagyása
                           .Select(sor => new Furdo(sor))
                           .ToList();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"Hiba: A fájl '{fajlnev}' nem található!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                // A program ne fusson tovább
                Environment.Exit(1);
                return new List<Furdo>(); // Ez csak a fordító miatt van itt
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba a fájl beolvasása közben: {ex.Message}", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                Environment.Exit(1);
                return new List<Furdo>(); // Ez csak a fordító miatt van itt
            }
        }

        private void FurdoDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (furdoDataGrid.SelectedItem is Furdo kivalasztottFurdo)
            {
                nevTextBox.Text = kivalasztottFurdo.Nev;
                cimTextBox.Text = kivalasztottFurdo.Cim;
                arTextBox.Text = kivalasztottFurdo.Ar.ToString();
                vizhofokTextBox.Text = kivalasztottFurdo.Vizhofok.ToString();
                vizhofokProgressBar.Value = kivalasztottFurdo.Vizhofok;
            }
        }

        private void MentesButton_Click(object sender, RoutedEventArgs e)
        {
            if (furdoDataGrid.SelectedItem is Furdo kivalasztottFurdo)
            {
                string fajlnev = $"{kivalasztottFurdo.Nev}.txt";
                try
                {
                    File.WriteAllLines(fajlnev, new string[]
                    {
                        $"Név: {kivalasztottFurdo.Nev}",
                        $"Cím: {kivalasztottFurdo.Cim}",
                        $"Ár: {kivalasztottFurdo.Ar}",
                        $"Vízhőfok: {kivalasztottFurdo.Vizhofok}"
                    });
                    MessageBox.Show($"A fürdő adatai elmentve a '{fajlnev}' fájlba.", "Mentés sikeres", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba a fájl mentése közben: {ex.Message}", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Nem menthető, amíg nincs kiválasztva semmi!", "Figyelmeztetés", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}