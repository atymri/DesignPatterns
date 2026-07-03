using AbstractFactoryPattern.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Wild
{
    /*
        Abstract Factory Pattern:
            This pattern is simular to Factory Method Pattern, but it is more complex. 
            It is used to create families of related or dependent objects without specifying their concrete classes. 
            It provides an interface for creating families of related or dependent objects 
            without specifying their concrete classes.
        
        in short, this pattern, is factory of factories.
        
        Real World Example:
            Suppose you want two types of tables, one wooden and one metal, 
            For wooden type, you need to visite a carpenter, for steel one, you need to go to a metal shop.
            All of these are factories, so, based on deman, you decide which kind of factory to choose.

        Computer World Example:
            ADO.NET implements this pattern for connection to database.
     */
    internal class WildAnimalFactory : IAnimalFactory
    {
        public ICat GetCat()
            => new WildCat();

        public IDog GetDog()
            => new WIldDog();
    }
}
