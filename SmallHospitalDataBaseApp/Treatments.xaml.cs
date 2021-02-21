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

namespace SmallHospitalDataBaseApp
{
    /// <summary>
    /// Interaction logic for newAddress.xaml
    /// </summary>
    public partial class Treatments : Window
    {
        public Treatments()
        {
            InitializeComponent();
            TreatmentService treatments = new TreatmentService();


            this.treatmentDataGrid.ItemsSource = treatments.GetList();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            treatmentDataGrid.Columns[5].Visibility = Visibility.Collapsed;

            treatmentDataGrid.Columns[0].Header = "Treatment ID";
            treatmentDataGrid.Columns[1].Header = "Treatment Name";
            treatmentDataGrid.Columns[2].Header = "Diagnosis ID";
            treatmentDataGrid.Columns[3].Header = "Treatment Date";
            treatmentDataGrid.Columns[4].Header = "Description";
        }


        private void update_address_button(object sender, RoutedEventArgs e)
        {
            // something
        }

        private void refresh_button(object sender, RoutedEventArgs e)
        {
  
        }

        private void delete_address_button(object sender, RoutedEventArgs e)
        {
            // something
        }

        private void cancel_button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void treatmentDataGrid_Selection(object sender, SelectionChangedEventArgs e)
        {
            //smth
        }

        private void AdjustColumnOrder()
        {
            this.treatmentDataGrid.Columns[6].Visibility = Visibility.Collapsed;
            this.treatmentDataGrid.Columns[7].Visibility = Visibility.Collapsed;
            this.treatmentDataGrid.Columns[8].Visibility = Visibility.Collapsed;

            this.treatmentDataGrid.Columns[0].Header = "AddressID";
            this.treatmentDataGrid.Columns[1].Header = "City";
            this.treatmentDataGrid.Columns[2].Header = "Street";
            this.treatmentDataGrid.Columns[3].Header = "HomeNr";
            this.treatmentDataGrid.Columns[4].Header = "FlatNr";
            this.treatmentDataGrid.Columns[5].Header = "PostalCode";
        }
    }
}
