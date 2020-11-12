using System;
using System.Globalization;

namespace Exercício_individual___Tema_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco conta = new Banco();

            Console.Write("ENTRE COM O NÚMERO DA CONTA: ");
            conta.numConta = int.Parse(Console.ReadLine());

            Console.Write("ENTRE COM O TITULAR DA CONTA: "); //Digitar decimais com virgula, NÃO ponto.
            conta.titularConta = Console.ReadLine();

            Console.Write("HAVERÁ DEPOSITO INICIAL (S/N): ");
            conta.depositoInicial = Console.ReadLine();

            if(conta.depositoInicial == "S") //usar APENAS S ou N maisculo
            {
                Console.Write("ENTRE O VALOR DE DEPÓSITO INICIAL: ");
                conta.saldo = float.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("ENTRE COM UM VALOR PARA DEPÓSITO: "); //Digitar decimais com virgula, NÃO ponto.
            conta.deposito = float.Parse(Console.ReadLine());
            conta.AdcionaSaldo(conta.deposito);

            Console.WriteLine();
            Console.WriteLine("DADOS ATUALIZADOS: " + conta);

            Console.WriteLine();
            Console.Write("ENTRE COM UM VALOR PARA SAQUE: "); //Digitar decimais com virgula, NÃO ponto.
            conta.saque = float.Parse(Console.ReadLine());
            conta.RealizarSaque(conta.saque);

            Console.WriteLine();
            Console.WriteLine("DADOS ATUALIZADOS: " + conta);

            Console.ReadKey();
        }
    }
}
