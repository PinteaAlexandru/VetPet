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

namespace VetPet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tbCtrlVetPet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tbCtrlVetPet_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource mediciViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("mediciViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // mediciViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource programViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("programViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // programViewSource.Source = [generic data source]
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
