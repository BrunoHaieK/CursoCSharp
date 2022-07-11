using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class Conversoes
    {
        public static void Executar()
        {
            // Conversão implicita (não perde informação)
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            // Conversão Explicita (pode gerar perda de informação)
            double Nota = 9.7;
            int NotaTruncada = (int)Nota;
            Console.WriteLine("Nota truncada: {0}", NotaTruncada);

            //Conversão de intring para numero
            Console.Write("Digite sua idade ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            // Esse metodo tenta converter string e numero se nao conseguir ele traz o valor 0
            Console.Write("Digite o primeiro numero ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Reultado 1: {0}", numero1);

            Console.Write("Digite o segundo numero ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Reultado 2: {0}", numero2);



        }
    }
}
