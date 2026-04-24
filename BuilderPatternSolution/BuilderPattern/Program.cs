using System.Runtime.CompilerServices;
//using BuilderPattern_FirstImplementation;
using BuilderPattern_SecondImplementation;

namespace BuilderPattern
{
    /*
 * BUILDER PATTERN
 * this pattern is used to create complex objects
 *
 * GoF Definition:
 *   separate the object creation process in complex objects from its representations
 *   so the same object creation process can be used for different representations
 *
 * General Definition:
 *   The Builder pattern is useful for creating complex objects that have multiple
 *   parts. The object creation process should be independent of these parts; in other
 *   words, the construction process does not care how these parts are assembled. In
 *   addition, as per the definition, you should be able to use the same construction
 *   process to create different representations of the objects.
 *   According to the GoF, four different players are involved in this pattern
 *
 *   1. builder 
 *   2. concrete builder 
 *   3. director
 *   4. product 
 *
 *   builder object is an interface and assembles different parts of the product
 *   the concrete builder implements it.
 *   director is responsible for creating the product using the builder interface,
 *   at the same time it decides in which order the final product should be created.
 *   
 *   
 *   
 * real world example could be like this:
 *      when you (director) want to buy a personal computer (product),
 *      first you must order the parts, separately,
 *      then the assembler (concrete builder) assembles them for you
 */

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implementation#1
            //List<Car> cars = new List<Car>()
            //{
            //    new Car("BMW"),
            //    new Car("BENZ"),
            //    new Car("TOYOTA"),
            //    new Car("CHEVY"),
            //    new Car("FORD"),
            //    new Car("PRIDE") // lol
            //};

            //List<MotorCycle> motors = new List<MotorCycle>()
            //{
            //    new MotorCycle("MOTOR#1"),
            //    new MotorCycle("MOTOR#2"),
            //    new MotorCycle("MOTOR#3"),
            //    new MotorCycle("MOTOR#4"),
            //    new MotorCycle("MOTOR#5"),
            //    new MotorCycle("MOTOR#6")
            //};

            //var director = new Director();

            //foreach(var car in cars)
            //{
            //    director.Build(car);
            //    car.GetProduct().ShowDetails();
            //}

            //foreach (var motor in motors)
            //{
            //    director.Build(motor);
            //    motor.GetProduct().ShowDetails();
            //}

            #endregion

            #region Implementation#2

            // in this scenario client is the director
            // and I have implemented the method chaining!
            // you can use these methods in any order
            var customCar = new Car("FORD")
                .StartOperation("just started making a new ford, wish me luck!")
                .BuildBody("steel")
                .AddWHeels(4)
                .AddHeadlights(2)
                .EndOperation("just made my new ford!")
                .Construct();

            customCar.Show();

            // not so smart way:
            var anotherOne = new Car("MERCEDES BENZ");
            anotherOne.StartOperation();
            anotherOne.BuildBody();
            anotherOne.AddHeadlights(2);
            anotherOne.AddWHeels(4);
            anotherOne.EndOperation("ENJOY!");
            anotherOne.Construct().Show();


            #endregion

        }
    }
}
