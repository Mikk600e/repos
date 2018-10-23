using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Model
{
    class Size
    {
        private string value;
        public Size(int UsrSize)
            {
            AssignSize(UsrSize);
            }
        private string AssignSize(int UsrSize)
        {
            if (UsrSize == 0)
                value = "mini";
            else if (UsrSize == 1)
                value = "normal";
            else if (UsrSize == 2)
                value = "max";
            else value = "";
            return value;
        }

    }
}
