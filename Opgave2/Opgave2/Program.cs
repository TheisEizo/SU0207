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

            //Setup int with input from console
            var int1 = 0;
            Console.Write("Skriv int: ");
            try {
                inputText = Console.ReadLine();
                int1 = int.Parse(inputText);
            }
            catch (FormatException) { Console.WriteLine("Hey! Default = 0"); }
            finally { Console.WriteLine($"Tallet er {int1}\n"); }

            //Setup int with input from console
            var float2 = 0F;
            Console.Write("Skriv float: ");
            try {
                inputText = Console.ReadLine();
                inputText = inputText.Replace(".", ","); //Convert "," to "." for proper use
                float2 = float.Parse(inputText);
            }
            catch (FormatException) { Console.WriteLine("Hey! Default = 0"); }
            finally { Console.WriteLine($"Tallet er {float2}\n"); }

            //Add the two
            Console.WriteLine($"Summen er: {int1 + float2}");

            //To keep outputs on screen, wait for input
            Console.ReadKey();
        }
    }
}
