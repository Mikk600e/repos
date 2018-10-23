using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            DoTheThang();
        }
        public static void DoTheThang()
        {
            Console.WriteLine("Skriv ønsket tabel nummer: ");
            String IDTxt = Console.ReadLine();
            int ID = Int32.Parse(IDTxt);
            Console.Clear();
            string BudgetName = db.SelectStuff(ID);
            Console.WriteLine(BudgetName);
            string choice = Console.ReadLine();
            if (choice == "x")
            {
                Console.Clear();
                DoTheThang();
            }
            else { }

        }
    }
}
