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
    /// Logika interakcji dla klasy ManagerLoginWindow.xaml
    /// </summary>
    public partial class ManagerLoginWindow : Window
    {
        Manager manager = new Manager();
        public ManagerLoginWindow()
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            PasswordBox.Focus();
        }



        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.Key == Key.Enter)
            {
                if (PasswordBox.Password == manager.Haslo)
                {
                    ManagerMenu manMenu = new ManagerMenu();
                    manMenu.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    manMenu.Show();
                    
                    e.Handled = true;
                    this.Close();
                }
                
            }

        }

    }
}
