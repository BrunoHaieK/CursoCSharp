using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    public class EstruturaSwitch
    {
        // Strutura Switch, procurar mais detalhes na documentação do C#
        public static void Executar()
        {
            Console.Write("Digite a nota do meu atendimento de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Digite uma nota de 1 a 5");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;

                case 3:
                    Console.WriteLine("Regular");
                    break;

                case 4:
                    Console.WriteLine("Ótimo");
                    break;
                case 5:
                    Console.WriteLine("Exelente");
                    Console.WriteLine("Parabens! ");
                    break;
            }


        }
    }
}
