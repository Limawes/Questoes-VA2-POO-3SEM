using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HoraAula
    {
        public void horaAula()
        {
            Console.WriteLine("Exercício 1 selecionado!");
            Console.WriteLine("");
            Console.WriteLine("");

            decimal horaAula;
            int nivel;
            decimal valor = 0;

            Console.WriteLine("Qual seu nível? ");
            nivel = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas/aulas você tem? ");
            horaAula = decimal.Parse(Console.ReadLine());

            if (nivel == 1)
            {
                valor = horaAula * decimal.Parse("12,00");
                
            }
            else if (nivel == 2)
            {
                valor = horaAula * decimal.Parse("17,00");
            }
            else if (nivel == 3)
            {
                valor = horaAula * decimal.Parse("25,00");
            }

            Console.WriteLine(string.Format("O valor do seu pagamento é {0:N}", valor));
        }
    }
}
