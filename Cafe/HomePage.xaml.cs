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
using System.Windows.Navigation;
using Cafe.Form;

namespace Cafe
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public UserControl currentChildForm;
        public Button currentButton;
        public HomePage()
        {
            InitializeComponent();
            
        }
        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            currentButton = ButtonSelling;
            OpenChildForm(new Selling());
        }
        void Button_Choose(object senderButton)
        {
            if (senderButton != null)
            {
                DisableButton();
                currentButton = (Button)senderButton;
                currentButton.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#217CA3");
                currentButton.Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFFFFF");
                currentButton.FontWeight = FontWeights.Bold;
            }
        }
        public void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.Background = Brushes.Transparent;
                currentButton.Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString("#F7F6F4");
                currentButton.FontWeight = FontWeights.Normal;
            }
        }
        private void ButtonSelling_Click(object sender, RoutedEventArgs e)
        {
            Button_Choose(sender);
            OpenChildForm(new Selling());
        }

        private void ButtonAgent_Click(object sender, RoutedEventArgs e)
        {
            Button_Choose(sender);
        }

        private void ButtonProduct_Click(object sender, RoutedEventArgs e)
        {
            Button_Choose(sender);
        }

        private void ButtonStorage_Click(object sender, RoutedEventArgs e)
        {
            Button_Choose(sender);
        }

        private void ButtonEmployee_Click(object sender, RoutedEventArgs e)
        {
            Button_Choose(sender);
        }

        private void ButtonReport_Click(object sender, RoutedEventArgs e)
        {
            Button_Choose(sender);
        }

       
        void OpenChildForm(UserControl form)
        {
            if (currentChildForm != null)
            {
                MainPanel.Children.Clear();
            }

            currentChildForm = form;
            MainPanel.Children.Add(currentChildForm);
        }
    }
}
