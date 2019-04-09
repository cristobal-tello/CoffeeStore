using CoffeeStore.Model;
using System.Collections.Generic;

namespace CoffeeStore.DAL
{
    public interface ICoffeeRepository
    {
        Coffee GetACoffee();
        List<Coffee> GetCoffees();
        Coffee GetCoffeeById(int id);
        void DeleteCoffee(Coffee coffee);
        void UpdateCoffee(Coffee coffee);
    }
}