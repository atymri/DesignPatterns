using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorymethodPattern;

/*
    Remember the GoF Definition that said:
        "Define an interface for creating an object, but let subclasses decide which class to instantiate.
        Factory Method lets a class defer instantiation to subclasses"
    
    Here, this factory does not know which animal to create, 
        it just defines the interface for creating an animal and which animal this will create is decided by the client..
 */
public abstract class AnimalFactory
{
    public IAnimal CreateAnimal()
    {
        Console.WriteLine($"{nameof(AnimalFactory)}.{nameof(CreateAnimal)}: you can't ignore parent rules!");
        var animal = MakeAnimal();
        animal.Talk();
        return animal;
    }
    public abstract IAnimal MakeAnimal(string type);
    public abstract IAnimal MakeAnimal();
}
