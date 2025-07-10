using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1.Algoritmos
{
    internal class VerificadorIdadeVotacao
    {
        // Desenvolva um programa que verifica se uma pessoa pode votar
        // baseado na sua idade, considerando as regras brasileiras de votação
        /*
         * Menor de 16 anos: não pode votar
         * 16 ou 17 anos: voto facultativo
         * 18 a 69 anos: voto obrigatório
         * 70 anos ou mais: voto facultativo
         */
        public static void Init()
        {
            Console.WriteLine("Digite sua idade:");
            uint idade = Convert.ToUInt32(Console.ReadLine());

            string status;

            if (idade < 16)
            {
                status = "PROIBIDO";
            }
            else if (idade < 18)
            {
                status = "FACULTATIVO";
            }
            else if (idade < 70)
            {
                status = "OBRIGATÓRIO";
            }
            else
            {
                status = "FACULTATIVO";
            }

            Console.WriteLine($"Situação Eleitoral: {status}");
        }
    }
}
