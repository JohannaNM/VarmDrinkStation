using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarmDrinkStation.Drinks.Interfaces;

namespace VarmDrinkStation.Drinks.ConcreteDrinks
{
    internal class Water : IWarmDrink
    {
        // Implementerar en specifik varm dryck, i detta fall vatten
        public void Consume()
        {
            Console.WriteLine("Warm water is served."); // Utskrift vid konsumtion av vatten
        }
    }
}
