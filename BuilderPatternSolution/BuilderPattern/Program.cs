using System.Runtime.CompilerServices;

namespace BuilderPattern
{
    /*
     * BUILDER PATTERN
     * this pattern is used to create complex objects
     */

    internal interface IBuilder
    {
        void StartOperation();
        void CreateBody();
        void AddWheels();
        void AddHeadlights();
        void EndOperation();
        Product GetProduct();
    }

    internal class Director
    {
        private IBuilder _builder;
        public void Build(IBuilder builder)
        {
            _builder = builder;
            _builder.StartOperation();
            _builder.CreateBody();
            _builder.AddWheels();
            _builder.AddHeadlights();
            _builder.EndOperation();
        }
    }

    internal class Car : IBuilder
    {
        private Product _product;
        private string _brandName;

        public Car(string brandName)
        {
            _product = new Product();
            _brandName = brandName;
        }

        public void StartOperation()
            => Console.WriteLine(new string('-', 5) + "START" + new string('-', 5));

        public void CreateBody()
        {
            Console.WriteLine($"[+] creating the body for {_brandName}");
            _product.Add("BODY");
        }

        public void AddHeadlights()
        {
            Console.WriteLine($"[+] adding 2 headlights for {_brandName}");
            _product.Add("HEADLIGHT * 2");
        }

        public void AddWheels()
        {
            Console.WriteLine($"[+] adding 4 wheels for {_brandName}");
            _product.Add("WHEELS * 4");
        }


        public void EndOperation()
            => Console.WriteLine(new string('-', 5) + "FINISH" + new string('-', 5));


        public Product GetProduct()
            => _product;

    }

    internal class MotorCycle : IBuilder
    {
        private readonly Product _product;
        private string _modelName;

        public MotorCycle(string model)
        {
            _product = new Product();
            _modelName = model;
        }

        public void StartOperation()
            => Console.WriteLine(new string('-', 5) + "START" + new string('-', 5));
        public void CreateBody()
        {
            Console.WriteLine($"[^] adding the body for {_modelName}");
            _product.Add("BODY");
        }
        public void AddWheels()
        {
            Console.WriteLine($"[^] adding 2 wheels for {_modelName}");
            _product.Add("WHEELS * 2");
        }
        public void AddHeadlights()
        {
            Console.WriteLine($"[^] adding 1 headlight for {_modelName}");
            _product.Add("HEADLIGHT * 1");
        }
        public void EndOperation()
            => Console.WriteLine(new string('-', 5) + "FINISH" + new string('-', 5));

        public Product GetProduct()
            => _product;
    }

    internal class Product
    {
        private List<string> _parts;

        public Product()
        {
            _parts = new List<string>();
        }

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void ShowDetails()
        {
            foreach (var part in _parts)
                Console.WriteLine(part);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car("BMW"),
                new Car("BENZ"),
                new Car("TOYOTA"),
                new Car("CHEVY"),
                new Car("FORD"),
                new Car("PRIDE") // lol
            };

            List<MotorCycle> motors = new List<MotorCycle>()
            {
                new MotorCycle("MOTOR#1"),
                new MotorCycle("MOTOR#2"),
                new MotorCycle("MOTOR#3"),
                new MotorCycle("MOTOR#4"),
                new MotorCycle("MOTOR#5"),
                new MotorCycle("MOTOR#6")
            };

            var director = new Director();

            foreach(var car in cars)
            {
                director.Build(car);
                car.GetProduct().ShowDetails();
            }

            foreach (var motor in motors)
            {
                director.Build(motor);
                motor.GetProduct().ShowDetails();
            }


        }
    }
}
