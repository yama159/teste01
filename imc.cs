using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2_ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int largura = 5;
            int altura = 5;

            string[,] tabela = new string[altura, largura];

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < largura; j++)
                {
                    tabela[i, j] = " ";
                    if ((i % 2 != 0) && (j % 2 != 0))
                    {
                        tabela[i, j] = "+";
                    }
                    else if ((i % 2 != 0) && (j % 2 == 0))
                    {
                        tabela[i, j] = "-";
                    }
                    else if ((i % 2 == 0) && (j % 2 != 0))
                    {
                        tabela[i, j] = "|";
                    }
                }
            }

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < largura; j++)
                {
                    Console.Write(tabela[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
