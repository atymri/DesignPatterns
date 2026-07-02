using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorymethodPattern.SimplefactoryPattern
{
    /*
        SIMPLE FACTORY PATTERN
        The Simple Factory pattern creates an object without exposing the instantiation
        logic to the client.

        CONCEPT:
            In object oriented programming, a factory is such an object that can create other objects.
            A factory can be invoked in many ways, but most often, it uses a single method that can
            return objects with varying prototypes, "any subroutine that helps create new objects is 
            considered as as a Factory", most importantly, it helps you abstract the object creation process
            from the consumer of the application.
        
        Real World example woule be something like this:
            imagine you went to an restaurant, and you order an stake, the waiter may ask you whether 
            you like to have some spice on you stake, based on your choice, the cheff adds the spices to your dish.

     */
    public class Simplefactory
    {
        public IAnimal CreateAnimal()
        {
            return Choose() switch
            {
                1 => new Dog(),
                2 => new Tiger(),
                _ => throw new NotImplementedException()
            };
        }

        private byte Choose()
        {
            Console.Write("choose an animal\n[1]Dog\n[2]Tiger\n=:");
            if (byte.TryParse(Console.ReadLine(), out byte res) && (res == 1 || res == 2))
                return res;
            else
                Console.WriteLine("INVALID INPUT!, choosing dog by default.");
                return 1;
        }
    }
}
