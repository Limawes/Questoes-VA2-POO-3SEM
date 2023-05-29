using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Notas
    {
        public void nota()
        {
            Console.WriteLine("Exercício 2 selecionado!");
            Console.WriteLine("");
            Console.WriteLine(""); 

            decimal notas = 0;
            decimal somaNotas = 0;
            decimal medias = 0;

            for (int i = 1; i < 5; i++) {
                Console.WriteLine("Digite a nota {0}: ", i);
                notas = decimal.Parse(Console.ReadLine());

                if (notas > 10 || notas < 1)
                {
                    Console.WriteLine("Valor inválido, informe apenas entre 1 e 10!");
                    notas = decimal.Parse(Console.ReadLine());
                }

                somaNotas = somaNotas + notas;
            }

            medias = somaNotas / 4;

            Console.WriteLine("A média é: {0}", medias);

            if (medias >= 6) 
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

        }
    }
}
