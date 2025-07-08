using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1.Algoritmos
{
    internal class ClassificacaoNotas
    {
        // Sistema que verifica se o aluno é aprovado ou reprovado
        // Notas de 0 a 10
        // Aprovado: 7+ | Recuperação: 5+ | Reprovado: -5
        public static void Init()
        {
            Console.WriteLine("Digite a nota do aluno (0 a 10):");
            double Score = Convert.ToDouble(Console.ReadLine());

            string Result = "";

            if (Score > 10)
            {
                Result = "INVÁLIDO";
            }
            else if (Score >= 7)
            {
                Result = "APROVADO";
            }
            else if (Score >= 5)
            {
                Result = "RECUPERAÇÃO";
            }
            else if (Score >= 0)
            {
                Result = "REPROVADO";
            }
            else
            {
                Result = "INVÁLIDO";
            }

            Console.WriteLine($"Situação: {Result}");
        }
    }
}
