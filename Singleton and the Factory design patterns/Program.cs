using System;
using Singleton_and_the_Factory_design_patterns;

namespace SingletonDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricKettle kettle = ElectricKettle.GetInstance();
            kettle.Fill();
            kettle.Boil();
            kettle.Drain();
            Console.ReadLine();
        }
    }
}
