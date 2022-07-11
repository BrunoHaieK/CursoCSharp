using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper(); // Transforma o texto em Letras Maiusculas
            var saudacao2 = "olá".ToUpper().Insert(3, " World!"); // Transforma o texto em Letras Maiusculas e insere um texto na posição 3.
            var saudacao3 = "olá".ToUpper().Insert(3, " World!").Replace(" World", " Mundo"); // Transforma o texto em Letras Maiusculas e insere um texto na posição 3 e transforma o World em Mundo.

            Console.WriteLine(saudacao);
            Console.WriteLine(saudacao2);
            Console.WriteLine(saudacao3);

            
            Console.WriteLine("Teste".Length);

            string ValorImportante = null;
            Console.WriteLine(ValorImportante?.Length);



        }
    }
}
