using Pra.Wine.Keeper.Wpf.Class_Library;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Pra.Wine.Keeper.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WineCollection _wineCollection;
        private CollectionViewSource _wineViewSource;

        public MainWindow()
        {
            InitializeComponent();
            InitializeData();
            DataContext = _wineCollection;
        }

        private void InitializeData()
        {
            _wineCollection = WineSeeder.Seed();
            _wineViewSource = new CollectionViewSource { Source = _wineCollection };
            lstWine.ItemsSource = _wineViewSource.View; 
            DataContext = _wineCollection; 
            RefreshWineList();
        }

        private void RefreshWineList()
        {
            var searchTerm = txtFilter.Text;
            var drinkableDate = dtpFilter.SelectedDate;

            _wineViewSource.View.Filter = item =>
            {
                if (item is WineBox wine)
                {
                    var matchesSearch = string.IsNullOrEmpty(searchTerm) ||
                                        wine.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase);

                    var matchesDate = !drinkableDate.HasValue ||
                                      wine.PurchaseDate.AddMonths(wine.MinStorageMonths) <= drinkableDate;

                    return matchesSearch && matchesDate;
                }
                return false;
            };

            _wineViewSource.View.Refresh();
        }


        private void btnAddWine_Click_1(object sender, RoutedEventArgs e)
        {
            grpWineDetails.IsEnabled = true;
            btnSave.Visibility = Visibility.Visible;
            btnCancel.Visibility = Visibility.Visible;

            txtDescription.Clear();
            txtMinStorage.Clear();
            txtMaxStorage.Clear();
            dtpPurchaseDate.SelectedDate = DateTime.Now;
            txtNumBottles.Clear();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var description = txtDescription.Text;
                var minStorage = int.Parse(txtMinStorage.Text);
                var maxStorage = int.Parse(txtMaxStorage.Text);
                var purchaseDate = dtpPurchaseDate.SelectedDate ?? DateTime.Now;
                var numBottles = int.Parse(txtNumBottles.Text);

                var newWine = new WineBox(description, minStorage, maxStorage, purchaseDate, numBottles);
                _wineCollection.Add(newWine); 

                grpWineDetails.IsEnabled = false;
                btnSave.Visibility = Visibility.Hidden;
                btnCancel.Visibility = Visibility.Hidden;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            grpWineDetails.IsEnabled = false;
            btnSave.Visibility = Visibility.Hidden;
            btnCancel.Visibility = Visibility.Hidden;
        }

        private void btnDrinkBottle_Click(object sender, RoutedEventArgs e)
        {
            if (lstWine.SelectedItem is WineBox selectedWine)
            {
                if (!selectedWine.DrinkBottle()) 
                {
                    MessageBox.Show("You've consumed the last bottle!", "Stock Depleted", MessageBoxButton.OK, MessageBoxImage.Information);
                    _wineCollection.Remove(selectedWine); 
                }

                RefreshWineList(); 
            }
        }

        private void txtFilter_TextChanged_1(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            RefreshWineList();
        }

        private void dtpFilter_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            RefreshWineList();
        }

        private void lstWine_SelectionChanged_1(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (lstWine.SelectedItem is WineBox selectedWine)
            {
                grpWineDetails.IsEnabled = true;

                txtDescription.Text = selectedWine.Description;
                txtMinStorage.Text = selectedWine.MinStorageMonths.ToString();
                txtMaxStorage.Text = selectedWine.MaxStorageMonths.ToString();
                dtpPurchaseDate.SelectedDate = selectedWine.PurchaseDate;
                txtNumBottles.Text = selectedWine.NumberOfBottles.ToString();
                btnDrinkBottle.IsEnabled = true;
            }
            else
            {
                grpWineDetails.IsEnabled = false;
                btnDrinkBottle.IsEnabled = false;
            }
        }
    }
}
