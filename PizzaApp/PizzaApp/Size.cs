using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public enum pizzaSize
    {
        Mini, Normal, Max
    }

    class Size
    {
        public pizzaSize PizzaSize { get; set; }
        public Size(int SizeInput)
        {
            PizzaSize = (pizzaSize)SizeInput;
        }
    }
}
