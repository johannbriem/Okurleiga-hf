using Okurleiga_hf.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Okurleiga_hf.Windows.View
{
    /// <summary>
    /// Interaction logic for ViewWindow.xaml
    /// </summary>
    public partial class ViewWindow : Window
    {
        public ViewWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           this.DataContext = SharedContext.Apartments;
           // this.DataContext = SharedContext.Employees;
        }

        private void ApartmentsDataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {

            PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
            e.Column.Header = propertyDescriptor.DisplayName;

            // Fyrir hvert property sem þú vilt ekki sjá í tölfunni sem generate'ast - getur þú gert eftirfarandi if skipun
            // prófaðu að commenta hana burt og sjáðu muninn
            if (propertyDescriptor.DisplayName == "Database")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "ChangeTracker")
            {
                e.Cancel = true;
            }
            // Getur líka dynamically breytt headernum hérna svona...
            if (propertyDescriptor.DisplayName == "Configuration")
            {
                e.Column.Header = "Fjör í Keflavík!";

            }

        }


        private void CbiApartment_Selected(object sender, RoutedEventArgs e)
        {
            this.DataContext = SharedContext.Apartments;
        }

        private void CbiEmployees_Selected(object sender, RoutedEventArgs e)
        {
            this.DataContext = SharedContext.Employees;
        }

        private void CbiApartmentOwners_Selected(object sender, RoutedEventArgs e)
        {
            this.DataContext = SharedContext.ApartmentOwners;
        }

        private void CbiApartmentIncidents_Selected(object sender, RoutedEventArgs e)
        {
            this.DataContext = SharedContext.ApartmentIncidents;
        }

        private void CbiCustomers_Selected(object sender, RoutedEventArgs e)
        {
            this.DataContext = SharedContext.Customers;
        }

        private void CbiRents_Selected(object sender, RoutedEventArgs e)
        {
            this.DataContext = SharedContext.Rents;
        }

        private void menu_ButtonSaveClick(object sender, RoutedEventArgs e)
        {

        }

        private void menu_ButtonQuitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menu_ButtonChangeClick(object sender, RoutedEventArgs e)
        {

        }

        private void menu_ButtonDeleteClick(object sender, RoutedEventArgs e)
        {
                       
        }

        private void menu_ButtonEditClick(object sender, DataGridBeginningEditEventArgs e)
        {

        }

        private void CbModels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        
    }
}

