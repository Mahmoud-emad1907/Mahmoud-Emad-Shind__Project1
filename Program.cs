using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahmoud_Emad_Shind__Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number"); int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number"); int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            bool brime = true;
            for (int i = num1; i <= num2; i++)
            {
                for (int y = 2; y <= num2; y++)
                {
                    if (i % y == 0 && i != y)
                    {
                        brime = false;
                        break;
                    }
                }
                if (brime && i!=1)
                {
                    Console.WriteLine(i);
                }
                brime = true;
            }
        }
    }
}
