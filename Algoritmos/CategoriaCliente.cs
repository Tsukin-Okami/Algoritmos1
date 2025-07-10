using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1.Algoritmos
{
    internal class CategoriaCliente
    {
        // Desenvolva um sistema que classifica clientes em categorias
        // baseado no valor total de suas compras anuais
        /*
        * Bronze: até R$ 1.000 
        * Prata: R$ 1.001 a R$ 5.000
        * Ouro: R$ 5.001 a R$ 10.000
        * Diamante: acima de R$ 10.000
        */
        public static void Init()
        {
            Console.WriteLine("Digite o valor total das compras do ano:");
            double Total = Convert.ToDouble(Console.ReadLine());

            string Status;

            if (Total <= 1000)
            {
                Status = "Bronze";
            }
            else if (Total <= 5000)
            {
                Status = "Prata";
            }
            else if (Total <= 10000) 
            {
                Status = "Ouro";
            }
            else
            {
                Status = "Diamante";
            }

            Console.WriteLine($"Classificação: {Status}");
        }
    }
}
