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
    /// Interaction logic for Diagnosis.xaml
    /// </summary>
    public partial class Diagnosis : Window
    {
        public Diagnosis()
        {
            InitializeComponent();
            DiagnosisService diagnosis = new DiagnosisService();

            this.diagnosisDataGrid.ItemsSource = diagnosis.GetList();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //for (int index = 0; index < 5; index++)
            //{
            //    patientDataGrid.Columns[index].Visibility = Visibility.Visible;
            //}
            diagnosisDataGrid.Columns[0].Header = "Diagnosis ID";
            diagnosisDataGrid.Columns[1].Header = "Visit ID";
            diagnosisDataGrid.Columns[2].Header = "Illness Name";
            diagnosisDataGrid.Columns[3].Header = "Description";

            //for (int indexI = 0; indexI > 5; indexI++)
            //{
            //    patientDataGrid.Columns[indexI].Visibility = Visibility.Collapsed;

            //}
            diagnosisDataGrid.Columns[4].Visibility = Visibility.Collapsed;
            diagnosisDataGrid.Columns[5].Visibility = Visibility.Collapsed;
        }

        private void update_contact_button(object sender, RoutedEventArgs e)
        {
            // something
        }

        private void refresh_button(object sender, RoutedEventArgs e)
        {
            // something
        }

        private void delete_contact_button(object sender, RoutedEventArgs e)
        {
            // something
        }

        private void cancel_button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void diagnosisDataGrid_Selection(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
