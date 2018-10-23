using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public enum pizzaTopping
    {
        Champignon, Bacon, Jalapenos, Løg, Kylling, Kødsauce, Kebab, Skinke, FrisOregano, Pepperoni, Majs, Pølse, Rejer,
        Ananas, Bearnaise, Paprika, Tun, Taco, Oksekød, Salat, CremeFraicheDressing
    }

    class Toppings
    {
        public pizzaTopping pizzaTopping { get; set; }
        public Toppings(int ToppingsInput)
        {
            pizzaTopping = (pizzaTopping)ToppingsInput;
        }
    }
}
