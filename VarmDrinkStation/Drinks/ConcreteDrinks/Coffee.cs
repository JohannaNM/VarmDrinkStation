using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarmDrinkStation.Drinks.Interfaces;

namespace VarmDrinkStation.Drinks.ConcreteDrinks
{
    internal class Coffee : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Hot coffee is served.");
        }
    }
}
