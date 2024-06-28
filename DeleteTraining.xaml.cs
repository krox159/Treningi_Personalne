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

namespace TreningiPersonalne
{
    /// <summary>
    /// Logika interakcji dla klasy DeleteTraining.xaml
    /// </summary>
    public partial class DeleteTraining : Window
    {
        List<Trening> trainingsList = new List<Trening>();
        public DeleteTraining()
        {
            trainingsList = Globals.bazaDanych.Treningi;
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            TrainingsDataGrid.ItemsSource = null;
            TrainingsDataGrid.ItemsSource = trainingsList;
        }

        public DeleteTraining(Klient klient)
        {
            trainingsList = Globals.bazaDanych.Treningi.Where(t=>t.KlientId == klient.Id).ToList();
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            TrainingsDataGrid.ItemsSource = null;
            TrainingsDataGrid.ItemsSource = trainingsList;
        }


        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            trainingsList.RemoveAt(TrainingsDataGrid.SelectedIndex);
            TrainingsDataGrid.ItemsSource = null;
            TrainingsDataGrid.ItemsSource = trainingsList;
            Globals.AnulujTreningMenedzer(TrainingsDataGrid.SelectedIndex);
        }
    }
}
