using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_SecondImplementation
{
    // if you have a common logic along all the concrete builders, 
    // you can use an abstract class instead of an interface
    public interface IBuilder
    {
        // this time we return the IBuilder type for method chaining in director (or client)
        IBuilder StartOperation(string message = "starting operation");
        IBuilder AddWHeels(int count = 0);
        IBuilder AddHeadlights(int count = 0);
        IBuilder BuildBody(string message = "building the body");
        IBuilder EndOperation(string message = "finishing the operation");
        Product Construct();
    }

    public class Car : IBuilder
    {
        private Product _car;
        private readonly string _brand;
        public Car(string brand)
        {
            _car = new Product();
            _brand = brand;
        }

        public IBuilder StartOperation(string message = "starting operation")
        {
            Console.WriteLine(message);
            return this;
        }

        public IBuilder AddWHeels(int count = 0)
        {
            Console.WriteLine($"inserting {count} number of wheels to {_brand}");
            _car.AddPart($"WHEELS * {count}");
            return this;
        }
        public IBuilder AddHeadlights(int count = 0)
        {
            Console.WriteLine($"inserting {count} number of headlights to {_brand}");
            _car.AddPart($"HEADLIGHTS * {count}");
            return this;
        }
        public IBuilder BuildBody(string bodyType = "steel")
        {
            Console.WriteLine($"body type: {bodyType}");
            return this;
        }
        public IBuilder EndOperation(string message = "finishing the operation")
        {
            Console.WriteLine(message);
            return this;
        }
        public Product Construct()
        {
            return _car;
        }
    }

    public sealed class Product
    {
        private readonly List<string> _parts;

        public Product()
        {
            _parts = new List<string>();
        }

        public void AddPart(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nproduct completed as below:");
            foreach (var part in _parts)
                Console.WriteLine(part);
        }
    }
}