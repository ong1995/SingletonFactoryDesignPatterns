using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatterns
{
    public static class PizzaActionMessage
    {
        public static string PrepareMessage(PizzaStore pizzaStore, PizzaVariety style)
        {
            return $"Preparing Pizzeria {pizzaStore} Style {style} Using";
        }
        public static string CheeseIngredientsMessage(Ingredients ingredients)
        {
            return $"Dough: {ingredients.Dough}, Cheese: {ingredients.Cheese}, Sauce: {ingredients.Sauce}, Veggies: {string.Join(", ", ingredients.Veggies)}";
        }
        public static string ClamIngredientsMessage(Ingredients ingredients)
        {
            return $"Dough: {ingredients.Dough}, Clam: {ingredients.Clam}, Sauce: {ingredients.Sauce} and Cheese: {ingredients.Cheese}";
        }
        public static string VeggieIngredientsMessage(Ingredients ingredients)
        {
            return $"Dough: {ingredients.Dough}, Sauce: {ingredients.Sauce}, Veggies: {string.Join(", ", ingredients.Veggies)}";
        }

        public static string BakeMessage()
        {
            return "Baking at 135 degree Celsius for 25 minutes";
        }

        public static string CutMessage()
        {
            return "Cutting into diagonal pieces";
        }

        public static string BoxMessage(string color)
        {
            return $"Putting pizza in {color} coloured box";
        }
    }
}
