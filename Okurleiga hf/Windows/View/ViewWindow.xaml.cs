using Okurleiga_hf.Context;
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

        //void DataGrid_PreviewKeyDown(object sender, KeyEventArgs e)
        //{
        //    DataGrid dg = sender as DataGrid;
        //    if (dg != null)
        //    {
        //        DataGridRow dgr = (DataGridRow)(dg.ItemContainerGenerator.ContainerFromIndex(dg.SelectedIndex));
        //        if (e.Key == Key.Delete && !dgr.IsEditing)
        //        {
        //            // User is attempting to delete the row
        //            var result = MessageBox.Show(
        //                "About to delete the current row.\n\nProceed?",
        //                "Delete",
        //                MessageBoxButton.YesNo,
        //                MessageBoxImage.Question,
        //                MessageBoxResult.No);
        //            e.Handled = (result == MessageBoxResult.No);
        //        }
        //    }
        //}

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
            //if (apartmentsDataGrid == null)
            //{
            //    MessageBox.Show("Ekki hægt að eyða tómum dálk");
            //}
            //else
            //{
            //    SharedContext.delete            
        }

        private void menu_ButtonEditClick(object sender, DataGridBeginningEditEventArgs e)
        {

        }

        private void CbModels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
