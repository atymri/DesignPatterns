using System.Runtime.CompilerServices;

namespace Singleton
{
    //public sealed class Singleton
    //{
    //    /*
    //     * We are using volatile to ensure
    //     * that assignment to the instance variable finishes
    //     * before it's access.
    //     *
    //     *
    //       the volatile keyword helps provide a
    //       serialize access mechanism, so all threads observe the changes by any other
    //       thread as per their execution order. It ensures that the most current value is
    //       always present in the field.
    //     */
    //    private static volatile Singleton Instance = new Singleton();
    //    private static readonly object _lockObject = new Object();
    //    public int TotalInstances = 0;

    //    // this is used to prevent using the new block in object creation
    //    // we have a static constructor which is the main one
    //    private Singleton()
    //    {
    //        Console.WriteLine("-- private ctor started");
    //        TotalInstances++;
    //        Console.WriteLine("-- private ctor stopped");
    //    }

    //    public static Singleton GetInstence
    //    {
    //        get
    //        {
    //            // locking is expensive
    //            lock (_lockObject)
    //            {
    //                if (Instance is null)
    //                    Instance = new Singleton();
    //            }

    //            return Instance;
    //        }
    //    }

    //}


    // Singleton implementation using Lazy<T>
    public sealed class Singleton
    {
        // Custom delegate
        private delegate Singleton SingletonDelegateWithNoParameter();
        private static SingletonDelegateWithNoParameter _myDel = MakeSingletonInstance;

        // Using built-in Func<out TResult> delegate
        private static readonly Func<Singleton> MyFuncDelegate = MakeSingletonInstance;

        //lazy loading is a technique that you use to delay the object creation process.The basic
        //idea is that you should create the object only when it is truly required.This
        //method is useful when object creation is a costly operation.
        private static readonly Lazy<Singleton> Instance = new Lazy<Singleton>(
                //myDel() // Also ok. Using a custom delegate
                MyFuncDelegate()
        //() => new Singleton() // Using lambda expression
        );

        private static Singleton MakeSingletonInstance()
        {
            return new Singleton();
        }
        private Singleton() { }
        public static Singleton GetInstance => Instance.Value;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // error CS0122:
            // Singleton s = new Singleton();
            
            //Singleton s = Singleton.GetInstance;
            //Singleton s2 = Singleton.GetInstance;

            //Console.Write(s.TotalInstances + "\n"); // 1
            //Console.Write(s2.TotalInstances); // 1
        }
    }
}
