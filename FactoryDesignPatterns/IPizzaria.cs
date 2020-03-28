using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatterns
{
    public interface IPizzaria
    {
        void Order(string pizzaVariety);
        void Prepare();
        void Bake();
        void Cut();
        void Box();
        string GetSauce();
        string GetDough();
        string GetClam();
        string GetBoxColor();
        string GetCheese();
        List<string> GetVeggie();
        void ViewAllTransactions(List<string> transactions);
    }
}
