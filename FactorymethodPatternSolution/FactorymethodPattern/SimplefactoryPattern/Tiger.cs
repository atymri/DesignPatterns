using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorymethodPattern.SimplefactoryPattern
{
    public class Tiger : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("You better be running...");
        }
    }
}
