using Okurleiga_hf.Context;
using Okurleiga_hf.Models;
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
using System.Windows.Shapes;

namespace Okurleiga_hf.Windows
{
    /// <summary>
    /// Interaction logic for NewApartmentIncidentWindow.xaml
    /// </summary>
    public partial class NewApartmentIncidentWindow : Window
    {        
        ApartmentIncident ai;        

        public NewApartmentIncidentWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CollectionViewSource view = new CollectionViewSource();
            //SharedContext.dBContext.ApartmentIncidents.Load();            
            //SharedContext.dBContext.Apartments.Load();            
            //SharedContext.dBContext.Employees.Load();

            //SharedContext.ApartmentIncidents = SharedContext.dBContext.ApartmentIncidents.Local;            
            //SharedContext.Employees = SharedContext.dBContext.Employees.Local;
            //SharedContext.Apartments = SharedContext.dBContext.Apartments.Local;

            //cbApartments.SelectedItem = ai;

            //CollectionViewSource view = new CollectionViewSource();
            //SharedContext.dBContext.Apartments.Load();
            //SharedContext.Apartments = SharedContext.dBContext.Apartments.Local;

            //this.DataContext = SharedContext.Apartments;
            //this.DataContext = SharedContext.Employees;
            ai = new ApartmentIncident();
            this.DataContext = ai;


            view.Source = SharedContext.Apartments;
            view.Source = SharedContext.Employees;


        }

        private void btn_Close(object sender, RoutedEventArgs e)
        {
            //Reyna grípa það ef notandi er búinn að slá eitthvað inn og ætlar svo að hætta að hann fái það MessageBox sem spyr hvort að hann vilji hætta.
            //En eins og er fann ég bara leið til að athuga efstaboxið, ef þetta stendur enn eftir að ég er búinn að skila þá fann ég ekki leið til að athuga value í öllum.
            if (!string.IsNullOrEmpty(tbInfo.Text))
            {               
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Þú hefur ekki vistað. Ertu viss um að hætta?";
                string caption = "Ertu viss ?";
                MessageBoxButton buttons = MessageBoxButton.YesNo;
                MessageBoxResult result;

                // Sýnir MessageBoxið
                    result = MessageBox.Show(message, caption, buttons, MessageBoxImage.Stop);
                if (result == MessageBoxResult.Yes)
                {
                    // Closes the parent form.
                    this.Close();
                }
            }

                else
                {
                    this.Close();
                }

        }
    
        private void CbApartments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SharedContext.selectedApartment = (Apartment)cbApartments.SelectedItem;
        }

        private void btn_Save(object sender, RoutedEventArgs e)
        {
            
            SharedContext.dBContext.ApartmentIncidents.Add(ai);
            SharedContext.dBContext.SaveChanges();
            this.Close();
        }

        private void CbEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SharedContext.selectedEmployee = (Employee)cbEmployees.SelectedItem;
        }
    }
}
