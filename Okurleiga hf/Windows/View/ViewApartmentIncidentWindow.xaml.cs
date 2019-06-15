using Okurleiga_hf.Context;
using Okurleiga_hf.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
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
using System.Windows.Shapes;

namespace Okurleiga_hf.Windows
{
    /// <summary>
    /// Interaction logic for ViewApartmentIncidentWindow.xaml
    /// </summary>
    public partial class ViewApartmentIncidentWindow : Window
    {
        public ViewApartmentIncidentWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Okurleiga_hf.OkurleigaDataSet okurleigaDataSet = ((Okurleiga_hf.OkurleigaDataSet)(this.FindResource("okurleigaDataSet")));
            // Load data into the table ApartmentIncidents. You can modify this code as needed.
            Okurleiga_hf.OkurleigaDataSetTableAdapters.ApartmentIncidentsTableAdapter okurleigaDataSetApartmentIncidentsTableAdapter = new Okurleiga_hf.OkurleigaDataSetTableAdapters.ApartmentIncidentsTableAdapter();
            okurleigaDataSetApartmentIncidentsTableAdapter.Fill(okurleigaDataSet.ApartmentIncidents);
            System.Windows.Data.CollectionViewSource apartmentIncidentsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("apartmentIncidentsViewSource")));
            apartmentIncidentsViewSource.View.MoveCurrentToFirst();
        }
    }
}
