using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_ClaculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " mês você terá R$" + valorInvestido);
                contadorMes++;
            }

            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Após um mês você terá R$" + valorInvestido);

            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Após dois meses você terá R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}
