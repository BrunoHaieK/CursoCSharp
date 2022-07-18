using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0 && nota < 11)
            {
                Console.WriteLine("Aprovado com Honra! ");

            }
            else if (nota > 7.0 && nota < 9.0)
            {
                Console.WriteLine("Aprovado! ");

            }
            else if (nota >= 6.0 && nota <= 7.0)
            {

                Console.WriteLine("Essa foi por pouco! ");
            }
            else if (nota > 10)
            {
                Console.WriteLine("Digite uma nota de 0 a 10, por gentileza! ");
            }
            else
                Console.WriteLine("Reprovado! ");
        }
    }
}
