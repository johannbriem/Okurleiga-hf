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
            //SharedContext.dBContext.ApartmentIncidents.Load();
            //SharedContext.dBContext.ApartmentOwners.Load();
            //SharedContext.dBContext.Apartments.Load();
            //SharedContext.dBContext.Customers.Load();
            //SharedContext.dBContext.Employees.Load();
            

            view.Source = SharedContext.customers;
            this.DataContext = view;
        }

        private void menu_NewCustomerClick(object sender, RoutedEventArgs e)
        {               
            NewCustomerWindow win = new NewCustomerWindow();
            win.ShowDialog();            
        }

        private void menu_QuitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menu_NewApartmentClick(object sender, RoutedEventArgs e)
        {            
            NewApartmentWindow win = new NewApartmentWindow();
            win.ShowDialog();            
        }

        private void menu_NewApartmentIncidentClick(object sender, RoutedEventArgs e)
        {
            NewApartmentIncidentWindow win = new NewApartmentIncidentWindow();
            win.ShowDialog();
        }
        private void menu_NewApartmentOwnerClick(object sender, RoutedEventArgs e)
        {
            NewApartmentOwnerWindow win = new NewApartmentOwnerWindow();
            win.ShowDialog();
        }

        private void menu_NewRentClick(object sender, RoutedEventArgs e)
        {
            NewRentWindow win = new NewRentWindow();
            win.ShowDialog();
        }
        private void menu_ViewApartmentClick(object sender, RoutedEventArgs e)
        {
            ViewApartmentWindow win = new ViewApartmentWindow();
            win.ShowDialog();
        }

        private void menu_ViewApartmentOwnersClick(object sender, RoutedEventArgs e)
        {
            ViewApartmentOwnerWindow win = new ViewApartmentOwnerWindow();
            win.ShowDialog();
        }

        private void menu_ViewCustomersClick(object sender, RoutedEventArgs e)
        {
            ChangeCustomerWindow win = new ChangeCustomerWindow();
            win.ShowDialog();
        }

        private void menu_ViewApartmentIncidentsClick(object sender, RoutedEventArgs e)
        {
            ViewApartmentIncidentWindow win = new ViewApartmentIncidentWindow();
            win.ShowDialog();
        }

        private void menu_ViewRentClick(object sender, RoutedEventArgs e)
        {
            ViewRentWindow win = new ViewRentWindow();
            win.ShowDialog();
        }
    }
}
