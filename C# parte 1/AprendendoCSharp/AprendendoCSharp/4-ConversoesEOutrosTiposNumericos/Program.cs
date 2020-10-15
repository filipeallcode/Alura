using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4.");

            double salario;
            salario = 1200.50;

            // o int é uma variável que suporta valores de até 32 bits
            int salarioEmInteiro = (int)salario; // casting ou type cast
            Console.WriteLine(salarioEmInteiro);

            // o long é uma variável de 64 bits
            long idade = 13000000000;
            Console.WriteLine(idade);

            // o short é uma variável de 16 bits
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
