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
    /// Logika interakcji dla klasy ClientMenu.xaml
    /// </summary>
    public partial class ClientMenu : Window
    {
        public string ClientName;
        public Klient loggedClient;
        public ClientMenu(Klient klient)
        {
            loggedClient = klient;
            ClientName = klient.NazwaUzytkownika;
            InitializeComponent();
            ClientUsernameValue.Content = ClientName;


        }

        private void LogoutClient(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DeleteTraining(object sender, RoutedEventArgs e)
        {
            DeleteTraining deletetrainingWindow = new DeleteTraining();
            deletetrainingWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            deletetrainingWindow.Show();
        }

        private void ShowTrainings(object sender, RoutedEventArgs e)
        {
            ShowTrainings showtrainingsWindow = new ShowTrainings(loggedClient);
            showtrainingsWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            showtrainingsWindow.Show();
        }

        private void RegisterTraining(object sender, RoutedEventArgs e)
        {
            RegisterTraining trainingRegWindow  = new RegisterTraining(loggedClient);
            trainingRegWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            trainingRegWindow.Show();
        }
    }
}
