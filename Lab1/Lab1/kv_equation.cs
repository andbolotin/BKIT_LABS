using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    static class kv_equation
    {
        private static float A, B, C;
        public static void kv_equation_edit()
        {
            bool mistak = false;
            do
            {
                Console.Write("A= ");
                A = float.Parse(Console.ReadLine());
                Console.Write("B= ");
                B = float.Parse(Console.ReadLine());
                Console.Write("C= ");
                C = float.Parse(Console.ReadLine());
                if (A == 0)
                {
                    mistak = true;
                    Console.WriteLine("Incorrect. Please try again.");
                }
                else
                {
                    mistak = false;
                }
            }
            while (mistak == true);
        }
        public static void solv()
        {
            float D = B * B - 4 * A * C;
            if (D < 0)
                Console.WriteLine("There is no solutions");
            else
                if (D == 0)
                Console.WriteLine(-B / (2 * A));
            else
            {
                Console.WriteLine((-B + Math.Sqrt(D)) / (2 * A));
                Console.WriteLine((-B - Math.Sqrt(D)) / (2 * A));
            }

        }
    }
}
