using Okurleiga_hf.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using Okurleiga_hf.Models;
using Okurleiga_hf.Windows;
using System.Diagnostics;
using Okurleiga_hf.Windows.New;
using Okurleiga_hf.Windows.View;

namespace Okurleiga_hf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CollectionViewSource view = new CollectionViewSource();
            SharedContext.dBContext.ApartmentIncidents.Load();
            SharedContext.dBContext.ApartmentOwners.Load();
            SharedContext.dBContext.Apartments.Load();
            SharedContext.dBContext.Customers.Load();
            SharedContext.dBContext.Employees.Load();

            SharedContext.Customers = SharedContext.dBContext.Customers.Local;
            SharedContext.ApartmentIncidents = SharedContext.dBContext.ApartmentIncidents.Local;
            SharedContext.ApartmentOwners = SharedContext.dBContext.ApartmentOwners.Local;
            SharedContext.Employees = SharedContext.dBContext.Employees.Local;
            SharedContext.Apartments = SharedContext.dBContext.Apartments.Local;
            
        }
       

        private void BtnPopUpQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            btnOpenMenu.Visibility = Visibility.Collapsed;
            btnCloseMenu.Visibility = Visibility.Visible;
        }

        private void btnCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            btnOpenMenu.Visibility = Visibility.Visible;
            btnCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            NewRegistrationWindow win = new NewRegistrationWindow();
            win.Topmost = true;
            win.Show();
        }
    }
}
