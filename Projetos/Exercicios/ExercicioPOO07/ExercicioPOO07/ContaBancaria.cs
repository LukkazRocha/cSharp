using System.Globalization;

namespace ExercicioPOO07 {
    internal class ContaBancaria {

        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int numero, string titular) {
            NumeroDaConta = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this (numero, titular) {
            Depositar(saldo);
        }

        public void Depositar(double quanti) {
            Saldo += quanti;
        }

        public void Sacar(double quanti) {
            Saldo -= quanti + 5.0;
        }

        public override string ToString() {
            return "Conta "
                + NumeroDaConta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
