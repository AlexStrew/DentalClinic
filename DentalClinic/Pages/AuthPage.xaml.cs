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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        Core db = new Core();
        List<login> arrayUsers;
        public AuthPage()
        {
            InitializeComponent();
            arrayUsers = db.context.login.ToList();
        }


        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text != String.Empty && PasswordTextBox.Password != String.Empty && !String.IsNullOrWhiteSpace(LoginTextBox.Text) && !String.IsNullOrWhiteSpace(PasswordTextBox.Password))
            {

                int countRecord = arrayUsers
                .Where(x => x.login1 == LoginTextBox.Text && x.password == PasswordTextBox.Password)
                .Count();
                if (countRecord == 1)
                {

                    Properties.Settings.Default.loginClient = LoginTextBox.Text;
                    Properties.Settings.Default.Save();

                    this.NavigationService.Navigate(new DoctorPage());
                }
            }
            else
            {
                MessageBox.Show("Пароль или логин не введен");
            }


            //this.NavigationService.Navigate(new DoctorPage());
        }

        private void serviceButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Service());
        }
    }
}
