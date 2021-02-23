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
        VisitService VisitService = new VisitService();
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

        private void add_visit_button(object sender, RoutedEventArgs e)
        {
            string datetime = visit_DateTextBox.Text;
            DateTime.TryParseExact(datetime, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime date);


            if (visit_doctorIDTextBox.Text != "" && visit_patientIDTextBox.Text != "" && visit_DateTextBox.Text != "")
            {
                string doct = visit_doctorIDTextBox.Text;
                string pat = visit_patientIDTextBox.Text;
                try
                {
                    int doctResult = Int32.Parse(doct);
                    int patResult = Int32.Parse(pat);
                    // Output: Unable to parse ''
                    VisitService.AddVisit(doctResult, patResult, date);
                }
                catch (FormatException)
                {
                    MessageBox.Show($@"Unable to parse '{doct}, {pat}'.
They must be numbers!");
                }

            }
            else MessageBox.Show("...Doctor ID, Visit ID & Date must be entered...");
        }

        private void delete_visit_button(object sender, RoutedEventArgs e)
        {

        }

        private void refresh_button(object sender, RoutedEventArgs e)
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
