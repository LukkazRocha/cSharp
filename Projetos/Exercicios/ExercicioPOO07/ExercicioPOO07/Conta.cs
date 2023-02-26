using System.Globalization;

namespace ExercicioPOO07 {
    internal class Conta {

        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular) {
            NumeroDaConta = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double saldo): this(numero, titular) {
            Saldo = saldo;
        }

        public void Depositar(double valor) {
            Saldo += valor;
        }

        public void Sacar(double valor) {
            Saldo = (Saldo - valor) - 5.0;
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
