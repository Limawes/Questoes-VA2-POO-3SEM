using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Execucao
    {
        public static void Main()
        {
            int opcao = 0;

            Console.WriteLine("Selecione qual exercício voce quer fazer: ");
            Console.WriteLine("1 - Valor das horas/aula de um professor: ");
            Console.WriteLine("2 - Saber a média das notas de um Aluno: ");
            Console.WriteLine("3 - Lanchonete ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    HoraAula exercicio1 = new HoraAula();
                    exercicio1.horaAula();
                    break;
                case 2:
                    Notas exercicio2 = new Notas();
                    exercicio2.nota();
                    break;
                case 3:
                    Lanchonete exercicio3 = new Lanchonete();
                    exercicio3.lanchonete();
                    break;
                default:
                    break;
            }
        }
    }
}
