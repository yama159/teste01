using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula03_ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Bhaskara bhask = new Bhaskara();
            bhask.a = a;
            bhask.b = b;
            bhask.c = c;

            if (bhask.TemRaizReal())
            {
                double x1 = bhask.GetX1();
                double x2 = bhask.GetX1();

                Console.WriteLine("As raizes são {0} e {1}" + x1, x2);
            }
            else
                Console.WriteLine("A raiz não percente aos números reais.");
        }
    }

    class Bhaskara{
        public double a, b, c;
        

        public double GetDelta()
        {
           return Math.Pow(b,2) - 4 * a * c;
                     
        }

        public bool TemRaizReal()
        {
            return GetDelta() >= 0;
        }

               
        public double GetX1()
        {
           return (-b + GetDelta()) / (2 * a);
        }

        public double GetX2()
        {
            return (-b - GetDelta()) / (2 * a);
        }

    }



}
