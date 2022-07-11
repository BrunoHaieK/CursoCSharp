using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    public class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual seu Salario? ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Seus dados São");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Seu nome é {nome}");
            Console.WriteLine($"Você tem {idade} anos");
            Console.WriteLine($"Você ganha R${salario} por mês");
            Console.ResetColor();
            

        }
    }
}
