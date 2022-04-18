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
    /// Логика взаимодействия для MKBListPage.xaml
    /// </summary>
    public partial class MKBListPage : Page
    {
        int idInspection;
        string codeInspetion;
        Core db = new Core();
        public MKBListPage()
        {
            InitializeComponent();
            RegionTreeView.ItemsSource = Tree.FillTreeNodeList(0);
        }
        private void RegionTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue != null)
            {
                idInspection = (e.NewValue as Node).ID;
                codeInspetion = (e.NewValue as Node).Code;
            }
        }
    }
}
