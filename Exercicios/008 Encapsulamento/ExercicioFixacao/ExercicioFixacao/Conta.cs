using System.Globalization;
using System.Net.Http.Headers;

namespace ExercicioFixacao {
    internal class Conta {

        public int Numero {get; private set; }
        public string Titular { get; set; }
        public double Saldo {get; private set; }

        public Conta(int num_conta, string nome_tit) {
            Numero = num_conta;
            Titular = nome_tit;
        }

        public Conta(int num_conta, string nome_tit, double dep_inicial) : this(num_conta, nome_tit) {
            Saldo = dep_inicial;
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= (quantia + 5.00);
        }

        public override string ToString() {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}

