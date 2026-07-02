using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorymethodPattern
{
    internal class ConcreteAnimalFactory : AnimalFactory
    {
        public override IAnimal MakeAnimal(string type)
        {
            Console.WriteLine($"{nameof(AnimalFactory)}.{nameof(MakeAnimal)}: you can't ignore parent rules!");
            IAnimal animal = type switch
            {
                "Dog" => new Dog(),
                "Cat" => new Cat(),
                _ => throw new ArgumentException($"Invalid animal type: {type}")
            };
            animal.Talk();
            return animal;
        }

        public override IAnimal MakeAnimal()
        {
            throw new NotImplementedException();
        }
    }
}
