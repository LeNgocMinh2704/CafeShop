using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using Cafe.ViewModel;
using MaterialDesignThemes.Wpf;

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
           
        }

       
        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            
        }

        //private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    txtPassword.Focus();
        //}

        private void textUsername_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtUsername.Focus();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Server=MINH;Database=CAFE; Integrated Security=True");
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                string query = "select count(1) from ACCOUNT where username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if(count == 1 && (CBRoles.SelectedItem as Roles).Name == "ADMIN")
                {
                    HomePage a = new HomePage();
                    a.Show();
                    this.Close();
                }
                else if (count == 2 && (CBRoles.SelectedItem as Roles).Name == "Employee")
                {
                    Employee a = new Employee();
                    a.Show();

                }
                else if (count == 3 && (CBRoles.SelectedItem as Roles).Name == "Accountant")
                {

                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            //if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Password))
            //{
            //    if((CBRoles.SelectedItem as Roles).Name ==  "ADMIN")
            //    {
            //        HomePage a = new HomePage();
            //        a.Show();
            //        this.Close();
            //    }
                
            //}
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
