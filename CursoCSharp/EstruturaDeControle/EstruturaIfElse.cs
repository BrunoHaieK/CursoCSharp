using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 6.0;

       
            if (nota >= 7.0)
            {
                Console.WriteLine("Parabens você foi aprovado! ");

            }
            else 
            {
                Console.WriteLine("Você foi reprovado. ");
            }


        }
    }
}
