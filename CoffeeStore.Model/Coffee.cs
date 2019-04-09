using System;
using System.ComponentModel;

namespace CoffeeStore.Model
{
    public class Coffee : INotifyPropertyChanged
    {
        private int coffeeId;
        private string coffeeName;
        private int price;
        private string description;
        private Country originCountry;
        private bool inStock;
        private int amountInStock;
        private DateTime firstAddedToStockDate;
        private int imageId;

        public int CoffeeId
        {
            get
            {
                return coffeeId;
            }
            set
            {
                coffeeId = value;
                RaisePropertyChanged("CoffeeId");
            }
        }

        public int Price
        { 
            get
            {
                return price;
            }
            set
            {
                price = value;
                RaisePropertyChanged("Price");
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                RaisePropertyChanged("Description");
            }
        }

        public Country OriginCountry
        {
            get
            {
                return originCountry;
            }
            set
            {
                originCountry = value;
                RaisePropertyChanged("OriginCountry");
            }
        }

        public bool InStock
        {
            get
            {
                return inStock;
            }
            set
            {
                inStock = value;
                RaisePropertyChanged("InStock");
            }
        }

        public int AmountInStock
        {
            get
            {
                return amountInStock;
            }
            set
            {
                amountInStock = value;
                RaisePropertyChanged("AmountInStock");
            }
        }

        public DateTime FirstAddedToStockDate
        {
            get
            {
                return firstAddedToStockDate;
            }
            set
            {
                firstAddedToStockDate = value;
                RaisePropertyChanged("FirstAddedToStockDate");
            }
        }

        public int ImageId
        {
            get
            {
                return imageId;
            }
            set
            {
                imageId = value;
                RaisePropertyChanged("ImageId");
            }
        }

        public string CoffeeName
        {
            get
            {
                return coffeeName;
            }
            set {
                coffeeName = value;
                RaisePropertyChanged("CoffeeName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
