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
using DentalClinic.Pages;
using HandyControl.Themes;
using HandyControl.Tools;

namespace DentalClinic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AuthPage());
            ThemeManager.Current.ApplicationTheme = ApplicationTheme.Light;
            //ThemeManager.Current.AccentColor = Brushes.;
            //ConfigHelper.Instance.SetWindowDefaultStyle();

        }

      

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void CloseWindowButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите закрыть программу?", "AHTUNG", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Application.Current.Shutdown();
            }
            else
            {
                MessageBox.Show("Тогда зачем нажимал?", "AHTUNG", MessageBoxButton.OK, MessageBoxImage.Question);
            }
        }

        private void MinimizeWindowButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }


        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (!MainFrame.CanGoBack)
            {
                BackButton.Opacity = 0;
                BackArrowImageButton.Opacity = 0;
                BackArrowImageButton.Visibility = Visibility.Collapsed;
                BackButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                BackArrowImageButton.Opacity = 1;
                BackButton.Opacity = 1;
                BackArrowImageButton.Visibility = Visibility.Visible;
                BackButton.Visibility = Visibility.Visible;
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack) { MainFrame.GoBack(); }
        }
    }
}
