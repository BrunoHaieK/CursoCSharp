using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;

            num1 += 10; //num1 = num1 + 10
            num1 -= 3;
            num1 *= 45;
            num1 /= 2;
            Console.WriteLine(num1);

            int a = 125;
            int b = a;
            a++; // operador de incremento
            b--; // operador de decremento
            Console.WriteLine($"{a} {b}");

            //Dynamic atribuição por referencia
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);


        }
    }
}
