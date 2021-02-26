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
        DiagnosisService DiagnosisService = new DiagnosisService();

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

        private void del_diagnosis_button(object sender, RoutedEventArgs e)
        {
            try
            {
                var diagnosis = DiagnosisService.SelectDiagID(diagnosisID);
                DiagnosisService.RemoveDiagnose(diagnosis);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Cannot remove that diagnosis.");
            }
            Refresh();
        }

        private void cancel_button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private int diagnosisID = 0;
        private void diagnosisDataGrid_Selection(object sender, SelectionChangedEventArgs e)
        {
            diagnosis d = this.diagnosisDataGrid.SelectedItem as diagnosis;
            if (d is null)
            {
                this.diagnosis_IDTextBox.Text = string.Empty.ToString();
                this.diagnosis_VisitIDTextBox_Copy.Text = string.Empty.ToString();
                this.diagnosis_IllnessNameTextBox_Copy.Text = string.Empty;
                this.diagnosis_DescriptionTextBox_Copy.Text = string.Empty;

                return;
            }
            this.diagnosis_VisitIDTextBox_Copy.Text = d.visit_id.ToString();
            this.diagnosis_IllnessNameTextBox_Copy.Text = d.illness_name;
            this.diagnosis_DescriptionTextBox_Copy.Text = d.description;
            var txt = this.diagnosisID = d.diagnosis_id;
            this.diagnosis_IDTextBox.Text = txt.ToString();
        }

        private void add_diagnosis_button(object sender, RoutedEventArgs e)
        {
            bool flag = false;
            if (diagnosis_VisitIDTextBox.Text != "" && diagnosis_IllnessNameTextBox.Text != "" && diagnosis_DescriptionTextBox.Text != "")
            {
                string input = diagnosis_VisitIDTextBox.Text;
                try
                {
                    int result = Int32.Parse(input);
                    // Output: Unable to parse ''
                    DiagnosisService.AddDiagnosis(result,
                                                diagnosis_IllnessNameTextBox.Text,
                                                diagnosis_DescriptionTextBox.Text);
                    flag = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show($@"Unable to parse '{input}'.
It must be a number!");
                    this.diagnosis_VisitIDTextBox.Text = string.Empty;
                }
                
            }
            else MessageBox.Show("...Visit ID, Illness Name & Description must be entered...");
            
            if (flag == true)
            {
                Refresh();
            }
        }

        private void Refresh()
        {
            Diagnosis newWindow = new Diagnosis();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            this.Close();
        }

        private void edit_diagnosis_button(object sender, RoutedEventArgs e)
        {
            if (diagnosis_VisitIDTextBox_Copy.Text != "" && diagnosis_IllnessNameTextBox_Copy.Text != "" && diagnosis_DescriptionTextBox_Copy.Text != "")
            {

                var diagnose = DiagnosisService.SelectDiagID(diagnosisID);

                string doct = diagnosis_VisitIDTextBox_Copy.Text.ToString().Trim();
                int a;
                bool doctRes = Int32.TryParse(diagnosis_VisitIDTextBox_Copy.Text.Trim(), out a);
                string b = diagnosis_IllnessNameTextBox_Copy.Text.ToString().Trim();
                if (!doctRes)
                {
                    MessageBox.Show("ID must be number");
                    return;
                }
                
                DiagnosisService.EditDiagnosis(diagnose, a, b, diagnosis_DescriptionTextBox_Copy.Text);
                Refresh();
            }
            else MessageBox.Show("All fields must be filled");

        }
    }
}
