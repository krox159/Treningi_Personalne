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
    /// Logika interakcji dla klasy ClientLoginWindow.xaml
    /// </summary>
    public partial class ClientLoginWindow : Window
    {
        public ClientLoginWindow()
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            ClientPasswordBox.Focus();
        }


        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string nazwaUzytkownika = UserLoginBox.Text;
                var klient = Globals.bazaDanych.Klienci.Find(k => k.NazwaUzytkownika == nazwaUzytkownika);
                if(klient != null && klient.Haslo == ClientPasswordBox.Password)
                {
                    ClientMenu clientMenu = new ClientMenu(klient);
                    clientMenu.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    clientMenu.Show();

                    e.Handled = true;
                    this.Close();
                }


                

            }

        }



    }
}
