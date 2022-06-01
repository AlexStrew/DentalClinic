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
    /// Логика взаимодействия для MKBWindow.xaml
    /// </summary>
    public partial class MKBWindow : Window
    {
        string selectedMKB;
        int idMKB;
        public string SelectedMKBCode { get; set; }
        string codeMKB;
        Core db = new Core();
        public MKBWindow()
        {
            InitializeComponent();


            RegionTreeView.ItemsSource = Tree.FillTreeNodeList(0);
        }
        private void RegionTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue != null)
            {
                idMKB = (e.NewValue as Node).ID;
                codeMKB = (e.NewValue as Node).Code;
            }

            Console.WriteLine(codeMKB);
            //Properties.Settings.Default.MKBCode = codeMKB;
            //Properties.Settings.Default.Save();

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.MKBCode = codeMKB;

            Properties.Settings.Default.Save();
            //selectedMKB = codeMKB;
            DialogResult = true;
            this.Close();
        }
    }
    
}
