using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Logika interakcji dla klasy ManagerMenu.xaml
    /// </summary>
    public partial class ManagerMenu : Window
    {
        public ManagerMenu()
        {
            InitializeComponent();
            
        }

        private void AddTrainer(object sender, RoutedEventArgs e)
        {
            AddTrainer trainerWindow = new AddTrainer();
            trainerWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            trainerWindow.Show();
        }

        private void ManagerLogout(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void DeleteTrainer(object sender, RoutedEventArgs e)
        {
            DeleteTrainer deletetrainerWindow = new DeleteTrainer();
            deletetrainerWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            deletetrainerWindow.Show();
        }

        private void ShowTrainers(object sender, RoutedEventArgs e)
        {
            ShowTrainers showtrainerWindow = new ShowTrainers();
            showtrainerWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            showtrainerWindow.Show();
        }

        private void ShowTrainings(object sender, RoutedEventArgs e)
        {
            ShowTrainings showtrainingsWindow = new ShowTrainings();
            showtrainingsWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            showtrainingsWindow.Show();
        }

        private void DeleteTraining(object sender, RoutedEventArgs e)
        {
            DeleteTraining deletetrainingWindow = new DeleteTraining();
            deletetrainingWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            deletetrainingWindow.Show();
        }

    }
}
