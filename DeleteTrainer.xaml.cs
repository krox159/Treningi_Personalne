using System;
using System.Collections.Generic;
using System.IO;
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
    /// Logika interakcji dla klasy DeleteTrainer.xaml
    /// </summary>
    public partial class DeleteTrainer : Window
    {
        List<Trener> trainersList = new List<Trener>();
        public DeleteTrainer()
        {
            trainersList = Globals.bazaDanych.Trenerzy;
            InitializeComponent();
            TrainersDataGrid.ItemsSource = null;
            TrainersDataGrid.ItemsSource = trainersList;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            trainersList.RemoveAt(TrainersDataGrid.SelectedIndex);
            TrainersDataGrid.ItemsSource = null;
            TrainersDataGrid.ItemsSource = trainersList;
            Globals.UsunTrenera(TrainersDataGrid.SelectedIndex);
        }




    }



}
