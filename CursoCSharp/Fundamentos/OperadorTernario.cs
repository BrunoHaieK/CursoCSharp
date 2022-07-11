using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class OperadorTernario
    {
        public static void Executar()
        {
            Console.Write("Digite o valor da sua nota: ");
            int.TryParse(Console.ReadLine(), out int nota);
            Console.Write("Teve Bom Comportamento? ");
            bool.TryParse(Console.ReadLine(), out bool BomComportamento);
            var resultado = nota >= 7.0 && BomComportamento? "Aprovado" : "Reprovado";//Operadores ternarios possuem tres etapas
                                                                   // parte 1        parte 2        parte3

            Console.WriteLine(resultado);

        }
    }
}
