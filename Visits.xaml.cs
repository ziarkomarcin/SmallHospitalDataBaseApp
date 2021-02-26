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

            visitDataGrid.Columns[0].Header = "Visit ID";
            visitDataGrid.Columns[1].Header = "Doctor ID";
            visitDataGrid.Columns[2].Header = "Patient ID";
            visitDataGrid.Columns[3].Header = "Visit Date";

        }

        private void add_visit_button(object sender, RoutedEventArgs e)
        {
            string datetime = visit_DateTextBox.Text;
            DateTime.TryParseExact(datetime, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime date);

            bool flag = false;
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

                    flag = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show($@"Unable to parse '{doct}, {pat}'.
They must be numbers!");
                }

            }
            else
            {
                MessageBox.Show("...Doctor ID, Visit ID & Date must be entered...");
                this.visit_IDTextBox.Text = string.Empty;
            }
            if (flag == true)
            {
                Refresh();
            }

        }

        private void delete_visit_button(object sender, RoutedEventArgs e)
        {
            try
            {
                var visit = VisitService.SelectVisitID(visitID);
                VisitService.RemoveVisit(visit);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Cannot remove that visit.");
            }
            Refresh();
        }

            private void Refresh()
        {
            Visits newWindow = new Visits();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            this.Close();
        }
      
        private void cancel_button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private int visitID = 0;
        private void visitDataGrid_Selection(object sender, SelectionChangedEventArgs e)
        {
            visits v = this.visitDataGrid.SelectedItem as visits;
            if (v is null)
            {
                this.visit_doctorIDTextBox2.Text = string.Empty.ToString();
                this.visit_patientIDTextBox2.Text = string.Empty.ToString();
                this.visit_DateTextBox2.Text = string.Empty;
                return;
            }
            this.visit_doctorIDTextBox2.Text = v.doctor_id.ToString();
            this.visit_patientIDTextBox2.Text = v.patient_id.ToString();
            this.visit_DateTextBox2.Text = v.date_of_visit.ToString();
            var txt = this.visitID = v.visit_id;
            this.visit_IDTextBox.Text = txt.ToString();
        }

        private void edit_visit_button(object sender, RoutedEventArgs e)
        {
            if (visit_doctorIDTextBox2.Text != "" && visit_patientIDTextBox2.Text != "" && visit_DateTextBox2.Text != "")
            {
                string date = visit_DateTextBox2.Text;
                DateTime.TryParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime newDate);

                var visit = VisitService.SelectVisitID(visitID);

                string doct = visit_doctorIDTextBox2.Text.Trim();
                int a;
                bool doctRes = Int32.TryParse(visit_doctorIDTextBox2.Text.Trim(), out a);
                if (!doctRes)
                {
                    MessageBox.Show("Doctor ID must be number");
                    return;
                }
                string pat = visit_patientIDTextBox2.Text.Trim();
                int b;
                bool patRes = Int32.TryParse(visit_patientIDTextBox2.Text.Trim(), out b);
                if (!patRes)
                {
                    MessageBox.Show("Patient ID must be number");
                    return;
                }
                if (a < 0)
                {
                    MessageBox.Show("ID cannot be less than 0.");
                    return;
                }
                if (b < 0)
                {
                    MessageBox.Show("ID cannot be less than 0.");
                    return;
                }
                VisitService.EditVisit(visit, a, b, newDate);
                Refresh();
            }
            else MessageBox.Show("All fields must be filled");
        }

    }
}
