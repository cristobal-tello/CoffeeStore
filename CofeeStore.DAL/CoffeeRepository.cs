using CoffeeStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeStore.DAL
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private static List<Coffee> coffees;
        private void LoadCoffees()
        {
            coffees = new List<Coffee>()
            {
                new Coffee()
                {
                    CoffeeId = 1,
                    CoffeeName = "Cafe aut late",
                    Description = "Simply the best french coffee",
                    ImageId = 1,
                    AmountInStock = 10,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2014, 1, 3),
                    OriginCountry = new Country("Ethiopia"),
                    Price = 12
                },
                new Coffee()
                {
                    CoffeeId = 2,
                    CoffeeName = "Capuccinno",
                    Description = "Best italian coffee",
                    ImageId = 2,
                    AmountInStock = 22,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2014, 2, 4),
                    OriginCountry = new Country("Italia"),
                    Price = 13
                },
                new Coffee()
                {
                    CoffeeId = 3,
                    CoffeeName = "Espresso",
                    Description = "Strong black coffee",
                    ImageId = 3,
                    AmountInStock = 33,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2014, 3, 5),
                    OriginCountry = new Country("Colombia"),
                    Price = 15
                }
            };
        }

        public void DeleteCoffee(Coffee coffee)
        {
            coffees?.Remove(coffee);
        }

        public Coffee GetACoffee()
        {
            if (coffees == null)
            {
                LoadCoffees();
            }
            return coffees.FirstOrDefault();
        }

        public Coffee GetCoffeeById(int id)
        {
            if (coffees == null)
            {
                LoadCoffees();
            }
            return coffees.Where(c => c.CoffeeId == id).FirstOrDefault();
        }

        public List<Coffee> GetCoffees()
        {
            if (coffees == null)
            {
                LoadCoffees();
            }
            return coffees;
        }

        public void UpdateCoffee(Coffee coffee)
        {
            var coffeeToUpdate = coffees.Where(c => c.CoffeeId == coffee.CoffeeId).FirstOrDefault();
            coffeeToUpdate = coffee;
        }
    }
}
