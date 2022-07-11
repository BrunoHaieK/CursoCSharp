using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class Interpolacao
    {
        public static void Executar()
        {
            //Definindo as Variaveis
            string nome = "Notebook Gamer";
            var marca = "Apple";
            double preco = 5800.00;

            var idade = 23;
            var nome2 = "Bruno Haiek";
            var trabalho = "DevJunior";
            bool namorada = true;

            // Concatenação
            Console.WriteLine("O " + nome + " da marca " + marca + "custa " + preco + ".");
            Console.WriteLine("Meu nome é " + nome2 + " Tenho " + idade + " anos, " + "trabalho como " + trabalho + " e tenho namorada " + namorada);

            //Interpolação
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca,preco);
            Console.WriteLine("Meu nome é {0} tenho {1} anos, trabalho como {2} e tenho namorada {3}", nome2, idade, trabalho, namorada);
            // ou
            Console.WriteLine($"A Marca {marca} é muito boa");
            Console.WriteLine($"1 + 1 = {1 + 1}!");
        }
    }
}
