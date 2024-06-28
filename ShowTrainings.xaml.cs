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
    /// Logika interakcji dla klasy ShowTrainings.xaml
    /// </summary>
    public partial class ShowTrainings : Window
    {
        List<Trening> trainingsList = new List<Trening>();
        public ShowTrainings()
        {
            trainingsList = Globals.bazaDanych.Treningi;
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            TrainingsDataGrid.ItemsSource = null;
            TrainingsDataGrid.ItemsSource = trainingsList;
        }

        public ShowTrainings(Klient klient)
        {
            trainingsList = Globals.bazaDanych.Treningi.Where(t=>t.KlientId==klient.Id).ToList();
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            TrainingsDataGrid.ItemsSource = null;
            TrainingsDataGrid.ItemsSource = trainingsList;
        }
    }
}
