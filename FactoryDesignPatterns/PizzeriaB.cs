using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatterns
{
    public class PizzeriaB : IPizzaria
    {
        public static PizzaVariety pizza;
        public List<string> transactions = new List<string>();

        public void Order(string pizzaVariety)
        {
            if (!Enum.IsDefined(typeof(PizzaVariety), pizzaVariety))
            {
                throw new Exception($"{pizzaVariety} is not in our menu.");
            }

            pizza = (PizzaVariety)Enum.Parse(typeof(PizzaVariety), pizzaVariety, true);
        }

        public void Prepare()
        {
            transactions.Add(PizzaActionMessage.PrepareMessage(PizzaStore.PizzeriaA, pizza));
            switch (pizza)
            {
                case PizzaVariety.CheesePizza:
                    var cheeseIngredients = new Ingredients()
                    {
                        Dough = GetDough(),
                        Cheese = GetCheese(),
                        Sauce = GetSauce(),
                        Veggies = GetVeggie()
                    };
                    transactions.Add(PizzaActionMessage.CheeseIngredientsMessage(cheeseIngredients));
                    break;
                case PizzaVariety.ClamPizza:
                    var clamIngredients = new Ingredients()
                    {
                        Dough = GetDough(),
                        Clam = GetClam(),
                        Cheese = GetCheese(),
                        Sauce = GetSauce()
                    };
                    transactions.Add(PizzaActionMessage.ClamIngredientsMessage(clamIngredients));
                    break;
                case PizzaVariety.VeggiePizza:
                    var veggieIngredients = new Ingredients()
                    {
                        Dough = GetDough(),
                        Sauce = GetSauce(),
                        Veggies = GetVeggie()
                    };
                    transactions.Add(PizzaActionMessage.VeggieIngredientsMessage(veggieIngredients));
                    break;
            }
        }

        public void Bake()
        {
            transactions.Add(PizzaActionMessage.BakeMessage());
        }

        public void Cut()
        {
            transactions.Add(PizzaActionMessage.CutMessage());
        }

        public void Box()
        {
            transactions.Add(PizzaActionMessage.BoxMessage(GetBoxColor()));
        }

        public string GetSauce()
        {
            return Sauce.PlumTomato.ToString();
        }

        public string GetDough()
        {
            return Dough.DeepDish.ToString();
        }

        public string GetClam()
        {
            return Clam.FreshClam.ToString();
        }

        public string GetBoxColor()
        {
            return ColorBox.Green.ToString();
        }

        public string GetCheese()
        {
            return Cheese.Parmesan.ToString();
        }

        public List<string> GetVeggie()
        {
            return new List<string>()
            {
                Veggie.Onions.ToString(),
                Veggie.BellPeppers.ToString(),
                Veggie.Cucumber.ToString()
            };
        }

        public void ViewAllTransactions(List<string> transactions)
        {
            foreach (var transaction in transactions)
            {
             Console.WriteLine(transaction);   
            }
        }
    }
}
