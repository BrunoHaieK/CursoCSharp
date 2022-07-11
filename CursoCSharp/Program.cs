using System;
using System.Collections.Generic;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Fundamentos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fundamentos
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternario - Fundamentos", OperadorTernario.Executar},

                //Estrutruras de Controle
                {"Estrutura If - Fundamentos", EstruturaIf.Executar},



            });

            central.SelecionarEExecutar();
        }
    }
}