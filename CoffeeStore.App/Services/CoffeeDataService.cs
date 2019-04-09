using CoffeeStore.DAL;
using CoffeeStore.Model;
using System.Collections.Generic;


namespace CoffeeStore.App.Services
{
    class CoffeeDataService : IDataService
    {
        ICoffeeRepository repository = new CoffeeRepository();

        public void DeleteCoffee(Coffee coffee)
        {
            repository.DeleteCoffee(coffee);
        }

        public List<Coffee> GetAllCoffees()
        {
            return repository.GetCoffees();
        }

        public Coffee GetCoffeeDetail(int coffeeId)
        {
            return repository.GetCoffeeById(coffeeId);
        }

        public void UpdateCoffee(Coffee coffee)
        {
            repository.UpdateCoffee(coffee);
        }
    }
}
