using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercício_individual___Tema_Banco
{
    class Banco
    {
        public int numConta;
        public string titularConta;
        public string depositoInicial;
        public float saldo = 0;
        public float deposito;
        public float saque;
        public float taxa = 5;

        public override string ToString()
        {
            return "DADOS DA CONTA: " + "CONTA " + numConta + ", TÍTULAR: " + titularConta + ", SALDO R$" + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdcionaSaldo(float Deposito)
        {
            saldo = saldo + Deposito;
        }

        public void RealizarSaque(float Saque)
        {
            saldo = saldo - taxa;
            saldo = saldo - Saque;

        }
    }
}
