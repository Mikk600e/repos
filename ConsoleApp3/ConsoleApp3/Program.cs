using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double omfang = Trekant();
            Resultat(omfang);
            Console.ReadLine();
        }
        static void Resultat (double omfang)
        {
            Console.WriteLine("---------------");
            Console.WriteLine(omfang);
            Console.WriteLine("===============");
        }
        static double Trekant()
        {
            double numbA, numbB, numbC;
            numbA = getSide("a");
            numbB = getSide("b");
            numbC = getSide("c");
            double omfang = numbA + numbB + numbC;
            return omfang;
        }    
        static double getSide(string sideName)
        {
            Console.WriteLine("Indtast side {0}", sideName);
            string trekantSide = Console.ReadLine();
            double numb = double.Parse(trekantSide);
            Console.WriteLine("");
            return numb;
        }
    }
}
