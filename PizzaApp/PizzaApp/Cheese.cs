using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public enum pizzaCheese
    {
        Hvede, OeladshvedeOgSpelt, Fuldkorn, Glutenfri, OekoNormal, OekoFuldKorn
    }

    class Cheese
    {
        public pizzaCheese PizzaCheese { get; set; }
        public Cheese(int CheeseInput)
        {
            PizzaCheese = (pizzaCheese)CheeseInput;
        }
    }
}
