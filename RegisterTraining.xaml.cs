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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TreningiPersonalne
{
    /// <summary>
    /// Logika interakcji dla klasy RegisterTraining.xaml
    /// </summary>
    public partial class RegisterTraining : Window
    {
        public Klient loggedClient;
        List<Trener> trainersList = new List<Trener>();
        public RegisterTraining(Klient klient)
        {
            loggedClient = klient;
            trainersList = Globals.bazaDanych.Trenerzy;
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            TrainersDataGrid.ItemsSource = null;
            TrainersDataGrid.ItemsSource = trainersList;
        }

        
        private void HourBox_Label_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Int32.TryParse(IdBox.Text, out int trainerId);
                var trener = Globals.bazaDanych.Trenerzy.Find(t => t.Id == trainerId);
                if (TimeSpan.TryParse(HourBox.Text, out TimeSpan godzina))
                {
                    if (TimeSpan.TryParse(TimeLength.Text, out TimeSpan czasTrwania))
                    {
                        Globals.treningIdCounter++;
                        var trening = new Trening(Globals.treningIdCounter, loggedClient.Id, trener.Id, DatePickBox.SelectedDate.Value + godzina, czasTrwania, $"{loggedClient.Imie} {loggedClient.Nazwisko}", $"{trener.Imie} {trener.Nazwisko}");
                        Globals.bazaDanych.DodajTrening(trening);
                        using (StreamWriter writetext = File.AppendText("treningi.txt"))
                        {
                            writetext.WriteLine(trening);
                        }
                        e.Handled = true;
                        this.Close();
                    }
                    else
                    {

                    }
                }


                else { 
                
                }



            }
        }


    }
}
