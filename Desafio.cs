using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Desafios = Algoritmos1.Desafios;

namespace Algoritmos1
{
    internal class Desafio
    {
        public static void Start()
        {
            Console.WriteLine("\tQual desafio deseja iniciar?\n-");

            Console.WriteLine("[1] Sistema de plano de saúde");

            Console.WriteLine("\n[0] Ir aos algoritmos\n-");

            Console.WriteLine("\nDigite o número desejado:");

            uint Selecao = Convert.ToUInt32(Console.ReadLine());

            switch (Selecao)
            {
                case 1:
                    Console.Clear();
                    Desafios.PlanoDeSaude.Init();
                    break;
                case 0:
                    Console.Clear();
                    Program.Main();
                    break;
            }

        }
    }
}
