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
            float a = 3 + 2;
            float b = 3 - 2;
            float c = 3 * 2;
            float d = 3 / 2f; // Adicionando 'f' para garantir que seja um float
            float e = 3 % 2;

            System.Console.WriteLine($"a: {a}, b: {b}, c: {c}, d: {d}, e: {e}");
            System.Console.ReadLine();
        }
    }
}
