using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Abstraction.AbstractClass;    // dengan Abstract Class
using Abstraction.Interface;      // dengan Interface

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*fashion fashion;          // Menggunakan Abstract Class

            Console.WriteLine();
            fashion = new sneakers();
            fashion.sepatu();
            Console.WriteLine();
            fashion = new boots();
            fashion.sepatu();
            Console.WriteLine();
            fashion = new pantofel();
            fashion.sepatu();
            Console.WriteLine();
            fashion = new sport();
            fashion.sepatu();
            Console.WriteLine();*/

            Ifashion fashion;       // Menggunakan Interface

            Console.WriteLine();
            fashion = new sneakers();
            fashion.sepatu();
            Console.WriteLine();

            fashion = new pantofel();
            fashion.sepatu();
            Console.WriteLine();

            fashion = new boots();
            fashion.sepatu();
            Console.WriteLine();

            fashion = new sport();
            fashion.sepatu();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}