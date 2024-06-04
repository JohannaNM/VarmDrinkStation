using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarmDrinkStation.Drinks.ConcreteDrinks;
using VarmDrinkStation.Drinks.Interfaces;
using VarmDrinkStation.Factories.Interfaces;

namespace VarmDrinkStation.Factories.ConcreteFactories
{
    internal class CoffeeFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml hot Coffee in your cup");
            return new Coffee();
        }
    }
}
