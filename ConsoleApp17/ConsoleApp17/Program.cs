using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        public delegate void MyDelegate (ref int res, int a, int b);

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            MyDelegate DoMafs = calc.ParkZone1;
            int res = 0;
            Console.WriteLine("Vælg Parkeringszone\n1\n2\n3\n4");
            int day = Int32.Parse(Console.ReadLine());
            int minutes = Int32.Parse(Console.ReadLine());

        }
    }
}
