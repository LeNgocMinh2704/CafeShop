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

namespace Cafe.Form
{
    /// <summary>
    /// Interaction logic for Selling.xaml
    /// </summary>
    public partial class Selling : UserControl
    {
        public Selling()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User() { BillID = 1, Employee = "John Doe", DateTime = new DateTime(1971, 7, 23) });
            users.Add(new User() { BillID = 2, Employee = "Jane Doe", DateTime = new DateTime(1974, 1, 17) });
            users.Add(new User() { BillID = 3, Employee = "Sammy Doe", DateTime = new DateTime(1991, 9, 2) });

            dg.ItemsSource = users;
        }
        public class User
        {
            public int BillID { get; set; }

            public string Employee { get; set; }

            public DateTime DateTime { get; set; }
        }

    }
}
