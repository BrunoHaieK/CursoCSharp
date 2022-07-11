using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class OperadoresLogicos
    {
        public static void Executar()
        {
            //Situação onde se você completou o trabalho 1 e o trabalho 2 vai gerar um resultado!
            var executouTrabalho1 = true;
            var executouTrabalho2 = true;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a Tv de 50 polegadas? {0}", comprouTv50);

            bool comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou Sorvete? {0}", comprouSorvete);

            bool comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv de 50 polegadas? {0}", comprouTv32);

            Console.WriteLine("Mais saudável {0}", !comprouSorvete);

        }
    }
}
