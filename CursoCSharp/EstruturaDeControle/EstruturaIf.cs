using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaIf
    {
        public static void Executar()
        {

            // Definindo a variavel
            bool BomComportamento = false;
            string entrada;

            // Pegando a nota no console
            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            //Pegando os dados no console
            Console.Write("Possui bom comportamento? (S/N):");
            entrada = Console.ReadLine();

            //if(entrada == "S" || entrada == "s")  // Expressão verdadeiro ou falso
            //    BomComportamento=true;

            //BomComportamento = entrada == "S" || entrada == "s";

            BomComportamento = entrada.ToLower() == "s";

            if(nota >= 9.0 && BomComportamento)
            {
                Console.WriteLine("Quado de honra! ");
            }
            

        }
    }
}
