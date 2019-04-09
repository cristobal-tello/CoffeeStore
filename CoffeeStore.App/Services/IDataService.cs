using CoffeeStore.Model;
using System.Collections.Generic;

namespace CoffeeStore.App.Services
{
    interface IDataService
    {
        Coffee GetCoffeeDetail(int coffeeId);
        List<Coffee> GetAllCoffees();
        void UpdateCoffee(Coffee coffee);
        void DeleteCoffee(Coffee coffee);
    }
}
