using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class PizzaViewModel
    {
        public PizzaViewModel()
        {

        }
        public static void FillPizza()
        {
            List<string> size = new List<string>();
            size.Add("Mini");
            size.Add("Normal");
            size.Add("Max");
        }
    }
}
