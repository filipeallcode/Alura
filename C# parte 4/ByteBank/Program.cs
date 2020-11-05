using System;
using System.Diagnostics;
using System.IO;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregaContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO MÉTODO MAIN");
            }
            
            Console.WriteLine("Execução finalizada. Tecle enter para sair.");
            Console.ReadLine();
        }

        private static void CarregaContas()
        {
            using(LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                leitor.LerProximaLinha();
            }

            // ------------------------------------------------

            //LeitorDeArquivos leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivos("contasl.txt");

            //    leitor.LerProximaLinha();
            //}
            //finally
            //{
            //    Console.WriteLine("Executando o finally");
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                // conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                // Console.WriteLine("Informações da INNER EXCEPRION (exceção interna): ");
            }
        }
    }
}
