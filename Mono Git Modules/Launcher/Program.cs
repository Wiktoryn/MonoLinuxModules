using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world from Launcher!");

            Console.WriteLine("Arguments:");

            Console.WriteLine(String.Join("|", args));
        }
    }
}
