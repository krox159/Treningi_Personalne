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
    /// Logika interakcji dla klasy ShowTrainers.xaml
    /// </summary>
    public partial class ShowTrainers : Window
    {
        List<Trener> trainersList = new List<Trener>();
        List<TrenerPoliHerm> trainersListHerm = new List<TrenerPoliHerm>();
        public ShowTrainers()
        {
            trainersList = Globals.bazaDanych.Trenerzy;
            //herm
            trainersListHerm = Globals.bazaDanych.PobierzTrenerow();


            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            TrainersDataGrid.ItemsSource = null;
            TrainersDataGrid.ItemsSource = trainersList;

            //herm
            //TrainersDataGrid.ItemsSource = null;
            //TrainersDataGrid.ItemsSource = trainersListHerm;
        }
    }
}
