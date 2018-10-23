using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class Pizza

    {
        Size size;
        Dough dough;
        Toppings toppings;
        Sauce sauce;
        Cheese cheese;
        public Pizza(int SizeInput, int DoughInput, int ToppingsInput, int SauceInput, int CheeseInput)
        {
            size = new Size(SizeInput);
            List<Size> Anders = new List<Size>();
            Anders.Add(size);
            dough = new Dough(DoughInput);
            toppings = new Toppings(ToppingsInput);
            sauce = new Sauce(SauceInput);
            cheese = new Cheese(CheeseInput);
        }
    }
}
