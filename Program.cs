using System;

using Algoritmos = Algoritmos1.Algoritmos;

namespace Algoritmos1
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("\tQual algoritmo deseja iniciar?\n-");

            Console.WriteLine("[1] Calculadora de Area");
            Console.WriteLine("[2] Conversor de Temperatura");
            Console.WriteLine("[3] Calculadora de Troco");
            Console.WriteLine("[4] Consumo de Combustivel");
            Console.WriteLine("[5] Classificação de Notas");
            Console.WriteLine("[6] Caixa Eletrônico");
            Console.WriteLine("[7] Maior de Dois Números");
            Console.WriteLine("[8] Verificador de Idade de Votação");
            Console.WriteLine("[9] Sistema de Categoria de Cliente");

            Console.WriteLine("\n[0] Ir aos desafios\n-");

            Console.WriteLine("\nDigite o número desejado:");

            uint selecao = Convert.ToUInt32(Console.ReadLine());

            switch (selecao)
            {
                case 1:
                    Console.Clear();
                    Algoritmos.CalculadoraArea.Init();
                    break;
                case 2:
                    Console.Clear();
                    Algoritmos.ConversorTemperatura.Init();
                    break;
                case 3:
                    Console.Clear();
                    Algoritmos.CalculadoraTroco.Init();
                    break;
                case 4:
                    Console.Clear();
                    Algoritmos.ConsumoCombustivel.Init();
                    break;
                case 5:
                    Console.Clear();
                    Algoritmos.ClassificacaoNotas.Init();
                    break;
                case 6:
                    Console.Clear();
                    Algoritmos.CaixaEletronico.Init();
                    break;
                case 7:
                    Console.Clear();
                    Algoritmos.MaiorDeDoisNumeros.Init();
                    break;
                case 8:
                    Console.Clear();
                    Algoritmos.VerificadorIdadeVotacao.Init();
                    break;
                case 9:
                    Console.Clear();
                    Algoritmos.CategoriaCliente.Init();
                    break;
                case 0:
                    Console.Clear();
                    Desafio.Start();
                    break;
            }
        }
    }
}