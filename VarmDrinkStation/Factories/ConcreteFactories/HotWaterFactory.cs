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
    internal class HotWaterFactory : IWarmDrinkFactory
    {
        // Implementerar en specifik fabrik som förbereder varmt vatten
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml hot water in your cup"); // Utskrift av mängden vatten som hälls upp
            return new Water(); // Returnerar en ny instans av Water
        }
    
    }
}
