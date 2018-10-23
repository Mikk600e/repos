using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("PID: ");
            int pid = Convert.ToInt32(Console.ReadLine());
            Process proc = Process.GetProcessById(pid);
            proc.Kill();
        }
    }
}
