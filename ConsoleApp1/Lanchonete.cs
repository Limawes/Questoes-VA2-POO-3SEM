using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lanchonete
    {
        public void lanchonete()
        {
            int codItem, qntd, exit;
            decimal valorTotal = 0;
            string item = string.Empty;

            do
            {
                Console.WriteLine("Cod.Item |  Especificação   | Preço unitário ");
                Console.WriteLine("     100 |  Cachorro Quente | R$ 1,10 ");
                Console.WriteLine("     101 |  Bauru Simples   | R$ 1,30");
                Console.WriteLine("     102 |  Bauru c/ Ovo    | R$ 1,50");
                Console.WriteLine("     103 |  Hambúrguer      | R$ 1,10");
                Console.WriteLine("     104 |  Cheeseburguer   | R$ 1,30");
                Console.WriteLine("     105 |  Refrigerante    | R$ 1,00");
                codItem = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a quantidade: ");

                while (codItem < 100 || codItem > 105)
                {
                    Console.WriteLine("Informe um valor apenas entre 100 e 105: ");
                    codItem = int.Parse(Console.ReadLine());

                } 

                qntd = int.Parse(Console.ReadLine());

                switch (codItem)
                {
                    case 100:
                        valorTotal = qntd * decimal.Parse("1,10");
                        item = " 100 |  Cachorro Quente | " + valorTotal;
                        break;
                    case 101:
                        valorTotal = qntd * decimal.Parse("1,30");
                        item = " 101 |  Bauru Simples   " + valorTotal;
                        break;
                    case 102:
                        valorTotal = qntd * decimal.Parse("1,50");
                        item = " 102 |  Bauru c/ Ovo    " + valorTotal;
                        break;
                    case 103:
                        valorTotal = qntd * decimal.Parse("1,10");
                        item = " 103 |  Hambúrguer   " + valorTotal;
                        break;
                    case 104:
                        valorTotal = qntd * decimal.Parse("1,30");
                        item = " 104 |  Cheeseburguer  " + valorTotal;
                        break;
                    case 105:
                        valorTotal = qntd * decimal.Parse("1,00");
                        item = " 105 |  Refrigerante   " + valorTotal;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Continuar comprando? Digite 1 para sim e  0 para Nao");
                exit = int.Parse(Console.ReadLine());

            } while (exit != 0);

            Console.WriteLine("Seu pedido é {0}", item);


        }
    }
}
