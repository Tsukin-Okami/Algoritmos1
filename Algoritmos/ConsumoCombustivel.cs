using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1.Algoritmos
{
    internal class ConsumoCombustivel
    {
        // Calcule quantos quilômetros um carro consegue percorrer com 1 litro de combustivel
        public static void Init()
        {
            Console.WriteLine("Digite a distância em Km(Quilômetros) percorrida pelo carro:");
            double Distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite quantos litros de combustível foram consumidos:");
            double Gas = Convert.ToDouble(Console.ReadLine());

            double DistancePerGas = Distance / Gas;

            Console.WriteLine($"O carro faz {DistancePerGas} Km/l");
        }
    }
}
