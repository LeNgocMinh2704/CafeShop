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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cafe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        List<Roles> RolesName;
        public Login()
        {
            InitializeComponent();
            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RolesName = new List<Roles>() {
                new Roles(){Name = "ADMIN"},
                new Roles(){Name = "Employee"},
                new Roles(){Name = "Accountant"},
            };
            CBRoles.ItemsSource = RolesName;
            CBRoles.DisplayMemberPath = "Name";
            
        }
        public class Roles
        {
            public string Name { get; set; }
        }
        private void txtUername_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUsername.Text) && txtUsername.Text.Length > 0)
            {
                textUsername.Visibility = Visibility.Collapsed;
            }
            else
            {
                textUsername.Visibility = Visibility.Visible;
            }
        }

       
        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
            {
                textPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPassword.Visibility = Visibility.Visible;
            }
        }

        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Focus();
        }

        private void textUsername_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtUsername.Focus();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Password))
            {
                if((CBRoles.SelectedItem as Roles).Name ==  "ADMIN")
                {
                    HomePage a = new HomePage();
                    a.Show();
                    this.Close();
                }
                
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void CloseButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        
    }
}
