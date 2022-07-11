using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class OperadoresRelacionais
    {
        // Nos operadores relacionais o resultado sempre será verdadeiro ou falso

        public static void Executar()
        {
            //double nota = 6.0;
            Console.Write("Digite sua Nota da Prova: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double NotaDeCorte = 7.0;

            Console.WriteLine("Nota Maior que 10? {0}", nota > 10.0);
            Console.WriteLine("Nota menor que 0? {0}", nota < 0.0);
            Console.WriteLine("Nota igual a 10 ? {0}", nota == 10.0);
            Console.WriteLine("Nota Diferente de 10 ? {0}", nota != 10.0);
            Console.WriteLine("Nota maior ou igual a nota de corte ? {0}", nota >= NotaDeCorte);
            Console.WriteLine("Nota menor que a nota de corte ? {0}", nota < NotaDeCorte);
            Console.WriteLine("Nota menor ou iguala nota de corte ? {0}", nota <= 3.0);

        }
    }
}
