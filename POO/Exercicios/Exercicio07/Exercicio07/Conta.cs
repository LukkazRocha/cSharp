using System.Globalization;

namespace Exercicio07
{
    public class Conta
    {
        public int NumeroDaConta { get; private set; }

        public string Titular { get; set; }

        public double Saldo { get; set; }

        public double DepositoInicial { get; set; }

        public Conta(int numeroDaConta, string titular)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
        }

        public Conta(int numeroDaConta, string titular, double depositoInicial) : this(numeroDaConta, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroDaConta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
