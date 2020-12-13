using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatriceConsoleCshap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cette app est une calculatrice");
            Console.WriteLine("A: Addition");
            Console.WriteLine("M: Multiplication");
            Console.WriteLine("S: Soustraction");
            Console.WriteLine("D: Division");
            Console.WriteLine("Choisissez une operation");
            char x =  char.Parse(String.ToUpper(Console.ReadLine()));
        }
    }
}
