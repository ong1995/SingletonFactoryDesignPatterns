using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatterns
{
    public enum Cheese
    {
        Mozzarella,
        Parmesan
    }
    public enum Clam
    {
        FreshClam,
        FrozenClam
    }
    public enum Dough
    {
        DeepDish,
        ThinCrust
    }
    public enum Sauce
    {
        CherryTomato,
        PlumTomato
    }
    public enum Veggie
    {
        Cucumber,
        Olives,
        Onions,
        BellPeppers
    }

    public enum PizzaVariety
    {
        CheesePizza,
        ClamPizza,
        VeggiePizza
    }

    public enum PizzaStore
    {
        PizzeriaA,
        PizzeriaB
    }

    public enum ColorBox
    {
        Red,
        Green
    }
}
