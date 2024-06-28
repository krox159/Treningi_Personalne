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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TreningiPersonalne
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            Globals.bazaDanych = new BazaDanych();

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Globals.WczytajBazeDanych();


            InitializeComponent();
        }

        private void ManagerLoginClick(object sender, RoutedEventArgs e)
        {
          ManagerLoginWindow win = new ManagerLoginWindow();
            win.Show();
        }

        private void ClientRegistration(object sender, RoutedEventArgs e)
        {
            ClientRegistrationForm frm = new ClientRegistrationForm();
            frm.Show();
        }

        private void ClientLogin(object sender, RoutedEventArgs e)
        {
            ClientLoginWindow win = new ClientLoginWindow();
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.Show();
        }

        private void ExitButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }






    }
}
