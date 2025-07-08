using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1.Algoritmos
{
    internal class ConversorTemperatura
    {
        // Crie um programa que converte temperatura de Celsius para Fahrenheit.
        // Você vai usar uma fórmula matemática específica para fazer essa
        public static void Init()
        {
            Console.WriteLine("Digite a temperatura em celsius que deseja converter:");
            double Celsius = Convert.ToDouble(Console.ReadLine());

            double Fahrenheit = (Celsius * 9 / 5) + 32;
            Console.WriteLine($"Convertido {Celsius}ºC para {Fahrenheit}ºF");
        }
    }
}
