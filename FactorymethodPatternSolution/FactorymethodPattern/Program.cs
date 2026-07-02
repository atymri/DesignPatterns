using FactorymethodPattern.SimplefactoryPattern;
using System;

namespace FactorymethodPattern
{
    /*
    GoF Definition:
        Define an interface for creating an object, but let subclasses decide which class to instantiate.
        Factory Method lets a class defer instantiation to subclasses.

    Real World Example:
        Imagine you are a software developer working for a company that develops a variety of software applications.
        The company has different teams that specialize in different types of applications, such as web applications,
        mobile applications, and desktop applications. Each team has its own development process and tools, and they
        need to create different types of objects depending on the type of application they are working on.
        To solve this problem, the company decides to implement the Factory Method pattern. They create an interface
        called IApplicationFactory that defines a method for creating objects. Each team then creates its own implementation
        of the IApplicationFactory interface, which creates objects specific to their type of application.
        For example, the web application team creates a WebApplicationFactory class that implements the IApplicationFactory
        interface and creates objects specific to web applications. The mobile application team creates a MobileApplicationFactory
        class that implements the IApplicationFactory interface and creates objects specific to mobile applications. The desktop
        application team creates a DesktopApplicationFactory class that implements the IApplicationFactory interface and creates
        objects specific to desktop applications.
        By using the Factory Method pattern, each team can create objects specific to their type of application without having to
        worry about the implementation details of other teams. This allows for greater flexibility and maintainability in the codebase,
        as each team can focus on their own development process and tools without interfering with other teams

    Conputer World Example:
        In database programming you may need to support diffrent database users, for example one user may be using 
        SQL Server, another user may be using Oracle, and another user may be using MySQL. 
        Each of these databases has its own way of connecting to the database, executing queries,
        And retrieving results. 
        To support these different databases, you can use the Factory Method pattern to create a common interface 
        For database connections and queries, and then create concrete implementations for each database type.
 */
    public class Program
    {
        // to see the explanation of this pattern, please refer to the SimplefactoryPattern folder.
        #region SimpleFactory
        //public static void Main()
        //{
        //    IAnimal animal = new Simplefactory().MakeAnimal();
        //    animal.Speak();
        //}
        #endregion

        #region FactoryPattern
        public static void Main()
        {
            Console.Write("select an animal to see it talk:\n[1]cat\n[2]dog\n=:");
            //var animal = Console.ReadLine() switch
            //{
            //    "1" => new CatFactory().CreateAnimal(),
            //    "2" => new DogFactory().CreateAnimal(),
            //    _ => throw new NotImplementedException()
            //};
            var animal = Console.ReadLine() switch
            {
                "1" => new ConcreteAnimalFactory().MakeAnimal("Cat"),
                "2" => new ConcreteAnimalFactory().MakeAnimal("Dog"),
                _ => throw new NotImplementedException()
            };
        }
        #endregion
    }
}