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

                        Okurleiga_hf.OkurleigaDataSet okurleigaDataSet = ((Okurleiga_hf.OkurleigaDataSet)(this.FindResource("okurleigaDataSet")));
            // Load data into the table Apartments. You can modify this code as needed.
            Okurleiga_hf.OkurleigaDataSetTableAdapters.ApartmentsTableAdapter okurleigaDataSetApartmentsTableAdapter = new Okurleiga_hf.OkurleigaDataSetTableAdapters.ApartmentsTableAdapter();
            okurleigaDataSetApartmentsTableAdapter.Fill(okurleigaDataSet.Apartments);
            System.Windows.Data.CollectionViewSource apartmentsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("apartmentsViewSource")));
            apartmentsViewSource.View.MoveCurrentToFirst();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /* Hérna langar mig til að birta uppls um alla þá dálka sem eru í þessum töflum hérna undir models ->
             * Byggt á því hvað er valið í Comboboxinu og svo bara breytt og eytt því sem er valið hérna inni Datagrid.*/
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
    }
}
