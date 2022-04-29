using DentalClinic.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DentalClinic.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        Core db = new Core();
        public AddPage()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            patients newPatient = new patients()
            {
                patient_first_name = FirstNameTextBox.Text,
                patient_last_name = LastNameTextBox.Text,
                date_of_birth = DatePicker.SelectedDate.Value
            };

            db.context.patients.Add(newPatient);
            db.context.SaveChanges();
            MessageBox.Show("Success");
        }
    }
}
