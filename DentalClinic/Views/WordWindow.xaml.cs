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

namespace DentalClinic.Views
{
    /// <summary>
    /// Логика взаимодействия для WordWindow.xaml
    /// </summary>
    public partial class WordWindow : Window
    {
        public WordWindow()
        {
            InitializeComponent();
        }

        private void DoctorButton_Click(object sender, RoutedEventArgs e)
        {
            JokeWindow jokeWindow = new JokeWindow();
            if (jokeWindow.ShowDialog() == true)
            {

            }
        }

        private void OthDiagBut_Click(object sender, RoutedEventArgs e)
        {
            JokeWindow jokeWindow = new JokeWindow();
            if (jokeWindow.ShowDialog() == true)
            {

            }
        }
    }
}
