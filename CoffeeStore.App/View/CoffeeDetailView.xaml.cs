using CoffeeStore.Model;
using System.Windows;

namespace CoffeeStore.App.View
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class CoffeeDetailView : Window
    {
        public Coffee SelectedCoffee { get; set; }

        public CoffeeDetailView()
        {
            InitializeComponent();

            this.Loaded += CoffeeDetailView_Loaded;
        }

        void CoffeeDetailView_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = SelectedCoffee;
        }

        private void ChangeCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            SelectedCoffee.CoffeeName = "Something really expensive";
            SelectedCoffee.Price = 10000;

        }

        private void SaveCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var c = SelectedCoffee;
        }
    }
}
