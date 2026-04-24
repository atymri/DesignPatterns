using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_FirstImplementation
{

    internal interface IBuilder
    {
        // the operations that must be done in order to create the final product
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
            // as said in general definition, director calls the methods,
            // based on the given concrete builder object, here builder can be anything that inherits from it.
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


}
