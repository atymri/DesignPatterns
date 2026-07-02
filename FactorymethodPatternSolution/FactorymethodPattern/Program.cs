using FactorymethodPattern.SimplefactoryPattern;
using System;

namespace FactorymethodPattern
{
    public class Program
    {
        #region SimpleFactory
        public static void Main()
        {
            IAnimal animal = new Simplefactory().CreateAnimal();
            animal.Speak();
        }
        #endregion
    }
}