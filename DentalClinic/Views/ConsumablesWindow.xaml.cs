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
using System.Windows.Shapes;

namespace DentalClinic.Views
{
    /// <summary>
    /// Логика взаимодействия для ConsumablesWindow.xaml
    /// </summary>
    public partial class ConsumablesWindow : Window
    {
        Core db = new Core();
        public ConsumablesWindow()
        {
            InitializeComponent();
        }

        private void SaveConsumablesButton_Click(object sender, RoutedEventArgs e)
        {
            consumables newCon = new consumables()
            {
                nozzle = Convert.ToInt32(NozzleTextBox.Text),
                anesthesia = Convert.ToInt32(AnestTextBox.Text),
                crown = Convert.ToInt32(CrownTextBox.Text),
                gel = Convert.ToInt32(GelTextBox.Text),
                vitamins = Convert.ToInt32(VitaTextBox.Text),
                basic_tools = Convert.ToInt32(BasicTextBox.Text),

            };

            db.context.consumables.Add(newCon);
            db.context.SaveChanges();
            MessageBox.Show("Success");

        }
    }
}
