using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1.Algoritmos
{
    internal class MaiorDeDoisNumeros
    {
        // Crie um programa que compara dois números digitados pelo usuário
        // e informa qual é o maior, ou se são iguais.
        public static void Init()
        {
            int FirstNumber, SecondNumber;
            
            Console.WriteLine("Digite o primeiro número:");
            FirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            SecondNumber = Convert.ToInt32(Console.ReadLine());

            if (FirstNumber == SecondNumber)
            {
                Console.WriteLine("Os números atribuídos são iguais");
            }
            else if (FirstNumber > SecondNumber)
            {
                Console.WriteLine($"O primeiro({FirstNumber}) número é maior que o segundo({SecondNumber}) número");
            }
            else
            {
                Console.WriteLine($"O segundo({SecondNumber}) número é maior que o primeiro({FirstNumber}) número");
            }
        }
    }
}
