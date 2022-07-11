using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class Inferencia
    {
        public static void Executar()
        {
            var nome = "Bruno Haiek";
            //nome = 123;
            Console.WriteLine(nome);

            //var idade; é preciso definir um valor para a variavel
            var idade = 32;
            Console.WriteLine("Valor da idade é " + idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);
        }
    }
}
