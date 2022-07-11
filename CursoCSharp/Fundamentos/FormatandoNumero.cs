using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    public class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));// transforma para Formato de casa decimal
            Console.WriteLine(valor.ToString("C"));// Tranforma para formato Moeda (valor monetario)
            Console.WriteLine(valor.ToString("P"));// Transforma para formato Percentual
            Console.WriteLine(valor.ToString("#.##"));// Transforma para formato de 2 casas decimais


            CultureInfo cultura = new CultureInfo("pt-BR");// Criando uma nova informação de cultura pra BR
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));// adiciona o 0 a esqueda


        }
    }
}
