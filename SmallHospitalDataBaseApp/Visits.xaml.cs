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

namespace SmallHospitalDataBaseApp
{
    /// <summary>
    /// Interaction logic for Visits.xaml
    /// </summary>
    public partial class Visits : Window
    {
        public Visits()
        {
            InitializeComponent();
            VisitService visit = new VisitService();

            this.visitDataGrid.ItemsSource = visit.GetList();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            visitDataGrid.Columns[4].Visibility = Visibility.Collapsed;
            visitDataGrid.Columns[5].Visibility = Visibility.Collapsed;
            visitDataGrid.Columns[6].Visibility = Visibility.Collapsed;
        }

        private void update_patient_button(object sender, RoutedEventArgs e)
        {
            // something
        }

        private void refresh_button(object sender, RoutedEventArgs e)
        {
            // something
        }

        private void delete_patient_button(object sender, RoutedEventArgs e)
        {
            // something
        }

        private void cancel_button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void visitDataGrid_Selection(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
