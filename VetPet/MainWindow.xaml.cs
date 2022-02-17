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
    /// 

    enum ActionState
        {
    New,
    Edit,
    Delete,
    Nothing }
    public partial class MainWindow : Window
    {
        ActionState action = ActionState.Nothing;
        VetPetEntitiesModel ctx = new VetPetEntitiesModel();
        CollectionViewSource mediciVSource;
        public MainWindow()
        {
            InitializeComponent();
            DataContext=this;
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
            mediciViewSource =
                 ((System.Windows.Data.CollectionViewSource)(this.FindResource("meidicViewSource")));
            mediciViewSource.Source = ctx.medici.Local;
            ctx.Medici.Load();
            System.Windows.Data.CollectionViewSource programViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("programViewSource")));
       
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         

        }
        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            action = ActionState.New;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            action = ActionState.Edit;
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            action = ActionState.Delete;
        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            mediciVScource.View.MoveCurrentToNext();
        }
        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            mediciVScource.View.MoveCurrentToPrevious();
        }

        private void SaveMedici()
        {
            medici = null;
            if (action ==ActionState.New)
            {
                try
                {
                    medici = new Medici()
                    {
                        numeColumn = numeTextBox.Text.Trim(),
                        prenumeColumn = prenumeTextBox.Text.Trim()
                    };
                    ctx.Medici.Add(medici);
                    mediciVSource.View.Refresh();
                    ctx.SaveChanges;

                }
                catch(DataException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
     if (action ==ActionState.Edit)
            {
                try
                {
                    medici=(Medici)medici.SelectedItem;
                    customer.Nume = numeTextBox.Text.Trim();
                    customer.Prenume = prenumeTextBox.Text.Trim();
                    ctx.SaveChanges();
                }
                catch(DataException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
    else if(action== ActionState.Delete)
            {
                try
                {
                    medici = (Medici)mediciDataGrid.SelectedItem;
                    ctx.Medici.Remove(medici);
                    ctx.SaveChanges();
                }
                catch(DataException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                mediciVScource.View.Refresh();
            }

        }
    }
}
