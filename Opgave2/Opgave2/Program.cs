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
            string inputText;

            var int1 = 0;
            Console.Write("Skriv int: ");
            try {
                inputText = Console.ReadLine();
                int1 = int.Parse(inputText);
            }
            catch (FormatException) { Console.WriteLine("Hey! Default = 0"); }
            finally { Console.WriteLine($"Tallet er {int1}\n"); }

            var float2 = 0F;
            Console.Write("Skriv float: ");
            try {
                inputText = Console.ReadLine();
                inputText = inputText.Replace(".", ",");
                float2 = float.Parse(inputText);
            }
            catch (FormatException) { Console.WriteLine("Hey! Default = 0"); }
            finally { Console.WriteLine($"Tallet er {float2}\n"); }

            Console.WriteLine($"Summen er: {int1 + float2}");

            Console.ReadKey();
        }
    }
}
