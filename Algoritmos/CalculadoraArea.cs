using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1.Algoritmos
{
    internal class CalculadoraArea
    {
        public static void Init()
        {
            Console.WriteLine("Digite a largura do retângulo:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do retângulo:");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = width * height;

            Console.WriteLine($"A área do retângulo é: {area} metros quadrados");
        }
    }
}