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
    /// Logika interakcji dla klasy AddTrainer.xaml
    /// </summary>
    public partial class AddTrainer : Window
    {
        public AddTrainer()
        {
            InitializeComponent();
            SurnameBox.Focus();
        }


        private void TrainerSurname_Keydown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

                var imie = NameBox.Text;
                var nazwisko = SurnameBox.Text;

                Globals.trenerIdCounter++;
                var trener = new Trener(Globals.trenerIdCounter, imie, nazwisko);
                Globals.bazaDanych.DodajTrenera(trener);
                
                using (StreamWriter writetext = File.AppendText("trenerzy.txt"))
                {
                    writetext.WriteLine(trener);
                }


                e.Handled = true;
                this.Close();


            }

        }

    }
}
