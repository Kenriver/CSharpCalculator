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
            string x = "";
            while (x != "E" && x != "e" )
            {
                
                Console.WriteLine("please enter your number 1 : ");
                double Num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("please enter your number 2 : ");
                double Num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("please select opration to calculate it:( + , - , / , * ) ");
                string Op = Console.ReadLine();

                switch (Op)
                {
                    case "+": Console.WriteLine(Math.Abs(Num1 + Num2)); break;
                    case "-": Console.WriteLine(Math.Abs(Num1 - Num2)); break;
                    case "*": Console.WriteLine(Math.Abs(Num1 * Num2)); break;
                    case "/":
                        if (Num2 == 0)
                            Console.WriteLine("cannot divide by zero");
                        else
                            Console.WriteLine(Math.Abs(Num1 / Num2));
                        break;
                    default:
                        Console.WriteLine("Invalid operator!");
                        break;
                }

                Console.WriteLine("select enter to continue or E(e) to exit this program");
                x = Console.ReadLine();
            }
        }
    }
}
