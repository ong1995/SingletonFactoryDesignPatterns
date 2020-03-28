using System;

namespace FactoryDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzeriaA = new PizzeriaA();
            pizzeriaA.Order(PizzaVariety.CheesePizza.ToString());
            pizzeriaA.ViewAllTransactions(pizzeriaA.transactions);


            var pizzeriaB = new PizzeriaB();
            pizzeriaB.Order(PizzaVariety.VeggiePizza.ToString());
            pizzeriaB.ViewAllTransactions(pizzeriaB.transactions);
        }
    }
}
