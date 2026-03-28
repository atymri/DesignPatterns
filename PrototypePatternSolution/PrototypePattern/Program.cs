using System.Runtime.InteropServices.ObjectiveC;
using System.Transactions;

namespace PrototypePattern
{
    // prototype pattern, something you have seen in AutoMapper!
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demonstration1
            //var factory = new CarFactory();

            //BaseCar ford = factory.GetFord();
            //Console.WriteLine($"\n[ORIGINAL]" +
            //                  $"\nmodel: {ford.ModelName}, " +
            //                  $"\nbasePrice: {ford.basePrice}, " +
            //                  $"\nonRoadPrice: {ford.onRoadPrice}");

            //BaseCar chevy = factory.GetChevy();
            //Console.WriteLine($"\n[ORIGINAL]" +
            //                  $"\nmodel: {chevy.ModelName}, " +
            //                  $"\nbasePrice: {chevy.basePrice}, " +
            //                  $"\nonRoadPrice: {chevy.onRoadPrice}");

            //BaseCar fordClone = ford.Clone();
            //fordClone.onRoadPrice = fordClone.basePrice + BaseCar.SetAdditionalPrice();
            //Console.WriteLine($"\n[CLONE]" +
            //                  $"\nmodel: {fordClone.ModelName}, " +
            //                  $"\nbasePrice: {fordClone.basePrice}, " +
            //                  $"\nonRoadPrice: {fordClone.onRoadPrice}");

            //BaseCar chevyClone = chevy.Clone();
            //chevyClone.onRoadPrice = chevyClone.basePrice + BaseCar.SetAdditionalPrice();
            //Console.WriteLine($"\n[CLONE]" +
            //                  $"\nmodel: {chevyClone.ModelName}, " +
            //                  $"\nbasePrice: {chevyClone.basePrice}, " +
            //                  $"\nonRoadPrice: {chevyClone.onRoadPrice}");
            #endregion

            #region Demonstration2

            var empAddress = new EmpAddress("123 abc street");
            var emp = new Employee(1, "someone", empAddress);

            // var clonedEmp = emp.Clone();
            var clonedEmp = new Employee(emp);

            empAddress.Address = "CHANGED FOR CLONE!";

            Console.WriteLine("[ORIGINAL]" + " " + emp);
            Console.WriteLine("[CLONED]  " + " " + clonedEmp);

            #endregion
        }
    }
}
