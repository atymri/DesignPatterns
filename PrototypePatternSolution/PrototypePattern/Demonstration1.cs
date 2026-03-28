using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    // sealed is the opposite of abstract
    public abstract class BaseCar
    {
        public int basePrice = 0, onRoadPrice = 0;
        public string ModelName { get; set; }

        public static int SetAdditionalPrice()
        {
            var rnd = new Random();

            int additionalPrice = rnd.Next(200_000, 500_000);

            return additionalPrice;
        }

        public abstract BaseCar Clone();

    }

    public class Ford : BaseCar
    {
        public Ford(string m)
        {
            basePrice = 100_000;
            ModelName = m;
        }
        public override BaseCar? Clone()
        {
            // This method (MemberwiseClone) is implemented in object class
            // it creates a shallow copy of the current object
            // we have two types of copy, shallow and deep copy 
            // WHAT THE HELL IS A SHALLOW COPY??

            // shallow copy: 
            // the basic type fields are copied to the cloned class, BUT 
            // for the reference type fields, only the references are copied.
            // in this way two objects may reference to the same object (it just copies the reference not the whole object), 
            // this can cause trouble in some cases.
            return this.MemberwiseClone() as Ford; // by default return type of this method is object
        }
    }

    public class Chevy : BaseCar
    {
        public Chevy(string m)
        {
            basePrice = 90_000;
            ModelName = m;
        }
        public override BaseCar Clone()
        {
            return this.MemberwiseClone() as Chevy;
        }
    }

    public class CarFactory
    {
        // for lazy implementation I commented out the readonly
        private volatile /*readonly*/ BaseCar ford, chevy;

        private readonly object _lock = new();
        //public CarFactory()
        //{
        //    ford = new Ford("Green Ford");
        //    chevy = new Chevy("Black Chevy");
        //}

        //public BaseCar GetChevy() => chevy.Clone();
        //public BaseCar GetFord() => ford.Clone();

        // lazy implementation:
        public BaseCar GetFord()
        {
            lock (_lock)
            {
                if (ford is not null)
                    return ford.Clone();

                ford = new Ford("Black Ford");
            }
            return ford;
        }

        public BaseCar GetChevy()
        {
            lock (_lock)
            {
                if (chevy is not null)
                    return chevy.Clone();
                chevy = new Chevy("Green Chevy");
            }
            return chevy;
        }

    }


}
