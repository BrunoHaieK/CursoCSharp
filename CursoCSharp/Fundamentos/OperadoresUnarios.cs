using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class OperadoresUnarios
    {
        public static void Executar()
        {
            var ValorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-ValorNegativo);
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);


        }
    }
}
