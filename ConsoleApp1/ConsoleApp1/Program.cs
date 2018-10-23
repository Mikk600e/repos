using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string nummertxt;
            int nummer;
            Console.Write("Indstast dit navn :");
            name = Console.ReadLine();
            Console.Write("Indstast dit nummer :");
            nummertxt = Console.ReadLine();
            nummer = Int32.Parse(nummertxt);
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Hej Verden " + name);
            Console.WriteLine("Hallo welt " + name);
            Console.WriteLine("Hola mundo " + name);
            Console.WriteLine("Bonjour mondo " + name);
            Console.WriteLine("hej " + name + "(Mobil: " + nummer + ")");
            Console.WriteLine("hej {0} (Mobil: {1}", name, nummer);
            Console.ReadLine();
        }
    }
}
