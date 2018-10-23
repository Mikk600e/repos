using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Model
{
    class Pizza
    {
        private int UsrSize;
        private int _size { get; set; }
        public void decideSize()
        {

            Size size = new Size(UsrSize);
            
        }
    }
}
