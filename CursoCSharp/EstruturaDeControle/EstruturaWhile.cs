using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16); //Gerar um valor entre 1 e 15, o 16 não encaixa
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativasAtual = 0;


            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativasAtual++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parabéns você acertou o numero secreto em {0} Tentativas", tentativasAtual);
                    Console.ResetColor();
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor.. voce tem mais {0} Tentativas", tentativasRestantes);
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("Maior.. voce tem mais {0} Tentativas", tentativasRestantes);
                }
            }
        }
    }
}
