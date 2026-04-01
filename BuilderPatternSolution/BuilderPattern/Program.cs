using System.Runtime.CompilerServices;
//using BuilderPattern_FirstImplementation;
using BuilderPattern_SecondImplementation;

namespace BuilderPattern
{
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
            // and i have implemented the method chaining!
            var customCar = new Car("FORD")
                .StartOperation()
                .BuildBody()
                .AddWHeels(4)
                .AddHeadlights(2)
                .EndOperation()
                .Construct();

            customCar.Show();

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
