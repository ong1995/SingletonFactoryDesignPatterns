using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Singleton_and_the_Factory_design_patterns
{
    /// <summary>
    /// Implement Singleton
    /// 1. Add a private static field to the class for storing the singleton instance.
    /// 2. Declare a public static creation method for getting the singleton instance.
    /// 3. Implement “lazy initialization” inside the static method.It should create a new object on its first call and put it into the static field.The method should always return that instance on all subsequent calls.
    /// 4. Make the constructor of the class private. The static method of the class will still be able to call the constructor, but not the other objects.
    /// 5. Go over the client code and replace all direct calls to the singleton’s constructor with calls to its static creation method.
    /// </summary>
    
    class ElectricKettle
    {
        private static ElectricKettle electricKettle;
        private static ElectricKettleStatus electricKettleStatus;
        private static string message;
        private ElectricKettle()
        {
            electricKettleStatus = ElectricKettleStatus.Empty;
            message = "Starting";
            Console.WriteLine(message);
        }

        public static ElectricKettle GetInstance()
        {
            if (electricKettle == null)
            {
                return new ElectricKettle();
            }

            return electricKettle;
        }

        public void Fill()
        {
            if (electricKettleStatus != ElectricKettleStatus.Empty)
            {
                return;
            };
            Thread.Sleep(6000);
            message = "Filling...";
            electricKettleStatus = ElectricKettleStatus.InProgress;
            Console.WriteLine(message);

        }
        public void Boil()
        {
            Thread.Sleep(6000);
            message = "Boiling...";
            electricKettleStatus = ElectricKettleStatus.Boiled;
            Console.WriteLine(message);
        }

        public void Drain()
        {
            Thread.Sleep(6000);
            message = "Draining...";
            electricKettleStatus = ElectricKettleStatus.Empty;
            Console.WriteLine(message);
        }
    }

    public enum ElectricKettleStatus
    {
        Empty,
        InProgress,
        Boiled
    }
}
