using AbstractFactoryPattern.Abstracts;
using AbstractFactoryPattern.Pet;
using AbstractFactoryPattern.Wild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class FactoryProvider
    {
        public static IAnimalFactory GetFactory(string type)
        {
            return type.ToLower() switch
            {
                "wild" => new WildAnimalFactory(),
                "pet" => new PetAnimalFactory(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
