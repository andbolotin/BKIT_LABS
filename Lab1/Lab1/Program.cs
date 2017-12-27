using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    class Program
    {
        static void Main_menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine();
            Console.WriteLine("1.Solve");
            Console.WriteLine("2.Put in new equation");
            Console.WriteLine("3.Exit");

        }
        static int Main(string[] args)
        {
            Console.WriteLine("Program to solve equation");
            Console.WriteLine("ax^2+bx+c=0");
            int n = 0;

            kv_equation.kv_equation_edit();
            Console.WriteLine();

            while (n != 3)
            {

                Main_menu();
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            kv_equation.solv();
                            break;
                        }
                    case 2:
                        {
                            kv_equation.kv_equation_edit();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Thank you for using this very program");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;
                }

            }
            return 0;
        }

    }

}
