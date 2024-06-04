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
    internal class HotChocolateFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml Hot Chocolate in your cup");
            return new HotChocolate();
        }
    }
}
