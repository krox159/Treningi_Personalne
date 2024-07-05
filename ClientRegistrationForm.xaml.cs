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
    /// Logika interakcji dla klasy ClientRegistrationForm.xaml
    /// </summary>
    public partial class ClientRegistrationForm : Window
    {
        public ClientRegistrationForm()
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }


        private void UserPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var nazwaUzytkownika = UserLogin.Text;
                if (Globals.bazaDanych.Klienci.Exists(k => k.NazwaUzytkownika == nazwaUzytkownika))
                {
                    //Console.WriteLine("Nazwa użytkownika już istnieje. Spróbuj ponownie.");
                    return;
                }

                var imie = UserName.Text;
                var nazwisko = UserSurname.Text;
                var haslo = UserPassword.Password;

                Globals.klientIdCounter++;
                var klient = new Klient(Globals.klientIdCounter, nazwaUzytkownika, imie, nazwisko, haslo);

                Globals.bazaDanych.DodajKlienta(klient);
                using (StreamWriter writetext = File.AppendText("klienci.txt"))
                {
                    writetext.WriteLine(klient);
                }

                e.Handled = true;
                    this.Close();
                

            }
        }

        private void UserPassword_KeyDown_Herm(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var nazwaUzytkownika = UserLogin.Text;
                if (Globals.bazaDanych.Klienci.Exists(k => k.NazwaUzytkownika == nazwaUzytkownika))
                {
                    //Console.WriteLine("Nazwa użytkownika już istnieje. Spróbuj ponownie.");
                    return;
                }

                var imie = UserName.Text;
                var nazwisko = UserSurname.Text;
                var haslo = UserPassword.Password;

                Globals.klientIdCounter++;
                var klientHerm = new KlientPoliHerm(Globals.klientIdCounter, nazwaUzytkownika, imie, nazwisko, haslo);

                Globals.bazaDanych.DodajKlienta(klientHerm);
                using (StreamWriter writetext = File.AppendText("klienci.txt"))
                {
                    writetext.WriteLine(klientHerm);
                    
                }

                e.Handled = true;
                this.Close();


            }
        }

    }
}
