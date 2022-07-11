using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class VariaveisEConstantes
    {

        public static void Executar()
        {
            // variavel area da circunferencia

            double raio = 4.5;

            // Contante n pode ser mudado
            const double PI = 3.14;

            // Juntando as duas variaveis 
            double area = PI * raio * raio;

            //Imprimindo o resultado no console
            Console.WriteLine(area);
            //Contatenação (junção)
            Console.WriteLine("Área é " + area*raio);

            //Tipos internos 

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte ValorMinimoSbyte = sbyte.MinValue;
            Console.WriteLine("Valor minimo é " + ValorMinimoSbyte);

            sbyte ValorMaximoSbyte = sbyte.MaxValue;
            Console.WriteLine("o Valor maximo de Sbyte é " + ValorMaximoSbyte);

            short ValorMinimoShort = short.MinValue;
            Console.WriteLine("O valor de Short é" + ValorMinimoShort);

            short ValorMaximoShort = short.MaxValue;
            Console.WriteLine("O valor maximo de Short é " + ValorMaximoShort);

            // Armazena numeros inteiros
            int MenorValorInt = int.MinValue; // Mais usado dos inteiros
            Console.WriteLine("O menor valor de Int é " + MenorValorInt);
            int MaiorValorInt = int.MaxValue;// Mais usado dos inteiros
            Console.WriteLine("O maior valor de int é " + MaiorValorInt);

            Console.ForegroundColor = ConsoleColor.Yellow;
            uint ValorMinimoUint = uint.MinValue;
            Console.WriteLine("Valor Minimo de UInt é  " +ValorMinimoUint);
            Console.ResetColor();
            uint popilacaoBrasileira = 207_600_00;
            Console.WriteLine("Uint cabe o numero da população brasileira " + popilacaoBrasileira);
            uint ValorMaximoUint = uint.MaxValue;
            Console.WriteLine("Valor maximo de UInt é " + ValorMaximoUint);

            long MenorValorLong = long.MinValue;
            Console.WriteLine("Menor valor Long " + MenorValorLong);

            long MaiorValorLong = long.MaxValue;
            Console.WriteLine("Menor valor Long " + MaiorValorLong);

            ulong PopulacaoMundial = 7_600_000_000;
            Console.WriteLine("Long sem sinal, numeros positivos" + PopulacaoMundial);

            
            float PrecoComputador = 1299.99f; // Armazena dados com casas decimais
            Console.WriteLine("Preço do Computador" + PrecoComputador);

            double ValorDeMercadoDaApple = 10000000000000.00; // Mais usado dos Reais
            Console.WriteLine("Valor Apple" + ValorDeMercadoDaApple);

            decimal DistanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Valor maximo variavel decimal" + DistanciaEntreEstrelas);
            decimal DistanciaEntreEstrelas2 = decimal.MinValue;
            Console.WriteLine("Valor minimo variavel decimal" + DistanciaEntreEstrelas2);

            char letra = 'b'; // Letra unica
            Console.WriteLine("Letra" + letra);

            string texto = "Seja bem vindo ao Curso de C#!"; //Texto inteiro
            Console.WriteLine(texto);


        }
    }
}
