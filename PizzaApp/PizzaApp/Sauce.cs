using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public enum pizzaSauce
    {
        NoSauce, Tomato, TomatoChilli, OekoTomato, OekoTomatoGarlic
    }

    class Sauce
    {
        public pizzaSauce PizzaSauce { get; set; }
        public Sauce(int SauceInput)
        {
            PizzaSauce = (pizzaSauce)SauceInput;
        }
    }
}
