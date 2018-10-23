using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public enum pizzaDough
    {
        Hvede, OeladshvedeOgSpelt, Fuldkorn, Glutenfri, OekoNormal, OekoFuldKorn 
    }

    class Dough
    {
        public pizzaDough PizzaDough { get; set; }
        public Dough(int DoughInput)
        {
            PizzaDough = (pizzaDough)DoughInput;
        }
    }
}
