using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSK_2_21_Lect1_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("input a");
            var str = Console.ReadLine(); // RE +/-Im

            MyComplex a = ParseComplex(str);

            string act = "+";

            Console.WriteLine("input b");
            str = Console.ReadLine(); // RE +/-Im

            MyComplex b = ParseComplex(str);


            var result = new MyComplex();

            switch (act)
            {
                case "+":
                    result = a + b;
                    break;
                case "||":
                    result.x = a.Abs();
                    break;
                default:
                    Console.WriteLine("Unknown action");
                    break;
            }

            Console.WriteLine($"Res.x = {result.x}   Res.y = {result.y}");

            Console.ReadKey();
        }

       
    }
}
