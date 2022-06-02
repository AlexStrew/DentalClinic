using DentalClinic.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DentalClinic.Pages
{
    /// <summary>
    /// Логика взаимодействия для PatientsListPage.xaml
    /// </summary>
    public partial class PatientsListPage : Page
    {
        Core db = new Core();
        List<patients> patientList;
        public PatientsListPage()
        {
            InitializeComponent();




            List<string> sortTypeList = new List<string>()
            {
                "А - Я", "Я - А"
            };
            SortComboBox.ItemsSource = sortTypeList;

        
            patientList = db.context.patients.ToList();
            PatientListView.ItemsSource = patientList;

            foreach (var item in patientList)
            {
                Console.WriteLine(item.patient_first_name);
            }
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(PatientListView.ItemsSource);
            view.Filter = UserFilter;

            //CollectionView viewDate = (CollectionView)CollectionViewSource.GetDefaultView(PatientListView.ItemsSource);
            //viewDate.Filter = UserFilterByDate;
            UpdateUI();
        }

        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(SearchTextBox.Text))
                return true;
            else
                return ((item as patients).patient_last_name.IndexOf(SearchTextBox.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        //private bool UserFilterByDate(object item)
        //{
        //    if (String.IsNullOrEmpty(SearchByDate.SelectedDate.ToString()))
        //        return true;
        //    else
        //        return ((item as appointment).date_app.ToString().IndexOf(SearchByDate.SelectedDate.ToString(), StringComparison.OrdinalIgnoreCase) >= 0);
        //}

        private void DescriptionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(PatientListView.ItemsSource).Refresh();

        }


        private void AddPatientButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddPage());
        }

        private void PatientListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UpdateUI()
        {
          
        }

   




        private void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateUI();
            

        }

        private void ReverseButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void FilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateUI();
        }

        private void GridViewColumn_Click(object sender, RoutedEventArgs e)
        {

        }



        private void EnrollButton_Click(object sender, RoutedEventArgs e)
        {
            Button activeButton = (Button)sender;
            patients activePatient = activeButton.DataContext as patients;
            Console.WriteLine(activePatient.id_patient);
            Properties.Settings.Default.patientSave = activePatient.id_patient;
            Properties.Settings.Default.Save();
            Console.WriteLine();
            this.NavigationService.Navigate(new PatientProfilePage());
        }




        private void DelPatientButton_Click(object sender, RoutedEventArgs e)
        {
            var item = PatientListView.SelectedItem as patients;
            if (item == null)

            {

                MessageBox.Show("Вы не выбрали ни одной строки");

                return;

            }

            else
            {


                MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите удалить строку?", "Удаление", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {


                    db.context.patients.Remove(item);

                    db.context.SaveChanges();

                    MessageBox.Show("Информация удалена");
                }
                PatientListView.ItemsSource = db.context.patients.ToList();
            }
        }

        private void RefreshByDateButton_Click(object sender, RoutedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(PatientListView.ItemsSource).Refresh();


        }
    }
}
