using System;
using Algoritmos = Algoritmos1.Algoritmos;

void Start()
{
    Console.WriteLine("Qual algoritmo deseja iniciar?\n-");

    Console.WriteLine("[1] Calculadora de Area");
    Console.WriteLine("[2] Conversor de Temperatura");
    Console.WriteLine("[3] Calculadora de Troco");
    Console.WriteLine("[4] Consumo de Combustivel");
    Console.WriteLine("[5] Classificação de Notas");
    Console.WriteLine("[6] Caixa Eletrônico");

    Console.WriteLine("\nDigite o número do algoritmo:");

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
        case 0:
            Console.WriteLine("Seleção inválida, digita novamente!");
            Console.WriteLine();
            Start();
            break;
    }
}

Start();