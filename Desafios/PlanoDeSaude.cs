using Algoritmos1.Algoritmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1.Desafios
{
    internal class PlanoDeSaude
    {
        // Crie um sistema que calcula o valor de um plano de saúde
        // baseado em idade, dependentes e tipo de plano.
        public enum Plano
        {
            Basico,
            Intermediario,
            Premium      
        }
        
        public static class PlanoValores
        {
            public static readonly Dictionary<Plano, double> Multiplicadores = new Dictionary<Plano, double>
            {
                { Plano.Basico, 1.0 },
                { Plano.Intermediario, 1.5 },
                { Plano.Premium, 2.0 }
            };
        }

        public static void Init()
        {
            Console.WriteLine("Digite a idade do titular:");
            uint TitularIdade = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de depentes:");
            uint TitularDependentes = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Selecione o tipo de plano:\n-");
            Console.WriteLine("[1] Básico");
            Console.WriteLine("[2] Intermediário");
            Console.WriteLine("[3] Premium");

            Console.WriteLine("-\nDigite o número do plano:");
            uint Selecao = Convert.ToUInt32(Console.ReadLine());

            // Armazena variaveis importantes
            Plano PlanoSelecionado;
            double TitularValor, ValorDependentes, ValorBase, ValorTotal;

            // Seleciona o tipo de plano
            switch (Selecao)
            {
                case 1:
                    PlanoSelecionado = Plano.Basico;
                    break;
                case 2:
                    PlanoSelecionado = Plano.Intermediario;
                    break;
                case 3:
                    PlanoSelecionado = Plano.Premium;
                    break;
                default:
                    Console.WriteLine("Plano selecionado inválido");
                    return;
            }

            // Verifica o valor base de acordo com a idade
            if (TitularIdade <= 18)
            {
                ValorBase = 150;
            }
            else if (TitularIdade <= 35)
            {
                ValorBase = 200;
            }
            else if (TitularIdade <= 50)
            {
                ValorBase = 300;
            }
            else if (TitularIdade <= 65)
            {
                ValorBase = 450;
            }
            else
            {
                ValorBase = 600;
            }

            TitularValor = ValorBase * PlanoValores.Multiplicadores[PlanoSelecionado];
            ValorDependentes = (TitularValor / 2) * TitularDependentes;

            ValorTotal = ValorDependentes +  TitularValor;

            Console.Clear();

            Console.WriteLine(
                $"Valor do Titular: R${TitularValor}" +
                $"\nValor dos Dependentes({TitularDependentes}): R${ValorDependentes}/R${ValorDependentes/TitularDependentes}" +
                $"\nPlano Mensal: R${ValorTotal}"
            );
        }
    }
}
