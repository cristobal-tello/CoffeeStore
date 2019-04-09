using CoffeeStore.App.Services;
using CoffeeStore.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CoffeeStore.App.View
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class CoffeeOverviewView : Window
    {
        public string CoffeeName { get; set; }

        private Coffee selectedCoffee;

        private ObservableCollection<Coffee> coffees;

        public object SelectedCofffee { get; private set; }

        public CoffeeOverviewView()
        {
            InitializeComponent();
            this.Loaded += CoffeeDetailViewLoaded;
        }

        private void CoffeeDetailViewLoaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            CoffeeDataService service = new CoffeeDataService();
            coffees = new ObservableCollection<Coffee>(service.GetAllCoffees());
            CoffeeListView.ItemsSource = coffees;

        }

        private void CoffeeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedCoffee = e.AddedItems[0] as Coffee;

            if (e != null)
            {
                CoffeeIdLabel.Content = selectedCoffee.CoffeeId;
                CoffeeNameLabel.Content = selectedCoffee.CoffeeName;
                DescriptionLabel.Content = selectedCoffee.Description;
                PriceLabel.Content = selectedCoffee.Price;
                StockAmountLabel.Content = selectedCoffee.AmountInStock.ToString();
                FirstTimeAddedLabel.Content = selectedCoffee.FirstAddedToStockDate.ToShortDateString();

                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.UriSource = new Uri("/JoeCoffeeStore.StockManagement.App;component/Images/coffee" + selectedCoffee.CoffeeId + ".jpg", UriKind.Relative);
                img.EndInit();
                CoffeeImage.Source = img;
            }
        }

        private void AddFakeCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            coffees.Add(
                new Coffee()
                {
                    CoffeeId = 123,
                    CoffeeName = "Test Coffee",
                    Description = "Simply another test coffee",
                    ImageId = 1,
                    AmountInStock = 100,
                    InStock = true,
                    FirstAddedToStockDate = DateTime.Now,
                    OriginCountry = new Country("Brazil"),
                    Price = 12
                });
        }

        private void EditCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            CoffeeDetailView coffeeDetailView = new CoffeeDetailView();
            coffeeDetailView.SelectedCoffee = selectedCoffee;
            coffeeDetailView.ShowDialog();
        }
    }
}
