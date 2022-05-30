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
    /// Логика взаимодействия для TeethMapView.xaml
    /// </summary>
    public partial class TeethMapView : Window
    {
        public TeethMapView()
        {
            InitializeComponent();
        }


        private void ButtonShowResults_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxOptions.Items.Cast<CheckBox>().Where(x => x.IsChecked == true).Select(x => x.Content).ToList();

            string str = string.Join(",", selectedItems);
            Properties.Settings.Default.teethMapArray = str;
            Properties.Settings.Default.Save();
            MessageBox.Show(string.Join(",", selectedItems));
            
            DialogResult = true;
            this.Close();
        }
    }
}
