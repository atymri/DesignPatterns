using AbstractFactoryPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Pet
{
    internal class PetAnimalFactory : IAnimalFactory
    {
        public ICat GetCat()
            => new PetCat();

        public IDog GetDog()
            => new PetDog();
    }
}
