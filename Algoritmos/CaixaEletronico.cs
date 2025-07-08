using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1.Algoritmos
{
    internal class CaixaEletronico
    {
        public static void Init()
        {
            double Saldo = 1000;

            Console.WriteLine($"Saldo da conta corrente: R${Saldo}");
            
            Console.WriteLine("Digite o valor do saque:");
            double Saque = Convert.ToDouble(Console.ReadLine());

            string Mensagem = "";

            if (Saque <= 0)
            {
                Mensagem = "Saque inválido, digite um valor acima de 0";
            }
            else if (Saque <= Saldo)
            {
                Saldo -= Saque;
                Mensagem = $"Confirmado saque de R${Saque}, saldo atual: R${Saldo}";
            } 
            else
            {
                Mensagem = "Recusado, o valor de saque é superior ao saldo atual";
            }

            Console.WriteLine($"[Saque]: {Mensagem}");
        }
    }
}
