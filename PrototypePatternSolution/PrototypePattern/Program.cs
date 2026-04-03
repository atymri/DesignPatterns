using System.Runtime.InteropServices.ObjectiveC;
using System.Transactions;

namespace PrototypePattern
{
    /*
     * PROTOTYPE PATTERN
     * each onject has to be created based on an specific prototype,
     * so for creating a new object, we copy that prototype
     *
     * GoF Definition:
     *   specify the types of objects to create using a prototypical instance,
     *   and create new objects by copying that prototype
     *
     * real world example could be like this:
     *   suppose that you have a master copy of a valuable document. You need to
     *   incorporate some changes to it to analyze the effect of the changes. In this case,
     *   you can make a photocopy of the original document and edit the changes in the
     *   photocopied document.
     *
     * computer world example could be like this:
     *   let’s assume that you already have a stable application. In the future, you may
     *   want to modify the application with some small changes. You must start with a
     *   copy of your original application, make the changes, and then analyze it further.
     *   You do not want to start from scratch merely to make a change; this would cost
     *   you time and money.
     *   In .NET, the ICloneable interface contains a Clone() method.
     */
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
