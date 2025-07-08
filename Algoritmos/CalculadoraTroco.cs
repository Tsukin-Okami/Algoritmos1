using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1.Algoritmos
{
    internal class CalculadoraTroco
    {
        // Simule uma situação de compra onde você precisa calcular o troco.
        // O programa deve pedir o valor da compra e o valor pago pelo cliente
        // depois calcular quanto de troco deve ser dado.
        public static void Init()
        {
            Console.WriteLine("Valor total da compra:");
            double Total = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor pago pelo cliente:");
            double Pago = Convert.ToDouble(Console.ReadLine());

            double Troco = Total - Pago;
            
            if (Troco == 0)
            {
                Console.WriteLine("Sem troco, o valor total da compra foi pago corretamente.");
            }
            else if (Troco < 0)
            {
                Console.WriteLine($"O cliente recebeu R${Math.Abs(Troco)} de troco.");
            }
            else
            {
                Console.WriteLine($"Faltou R${Troco} para terminar a compra.");
            }
        }
    }
}
