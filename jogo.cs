using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2_ex06
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int numero = rnd.Next(0, 10);
            bool acerto = false;
            int tentativas = 1;
            Console.WriteLine("Adivinhe o número entre 1 à 10.");
            do
            {

                Console.Write("digite o numero: ");
                int num = Convert.ToInt16(Console.ReadLine());

                if (num == numero)
                {
                    acerto = true;
                    Console.WriteLine("Você acertou em " + tentativas + " tentativas");

                }
                else
                {
                    Console.Write("Você errou, ");
                    if (num > numero)
                    {
                        Console.WriteLine("o número é menor ");
                    }
                    else
                    {
                        Console.WriteLine("o número é maior ");
                    }

                    tentativas++;
                }


            } while (acerto == false);







        }
    }
}
