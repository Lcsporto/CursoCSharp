using System.Globalization;
using System.Net.Http.Headers;

namespace ExercicioFixacao {
    internal class Conta {

        public int NumConta {get; private set; }
        public string NomeTit { get; set; }
        public double DepInicial { get; private set; }
        public double Saldo {get; private set; }

        public Conta(int num_conta, string nome_tit) {
            NumConta = num_conta;
            NomeTit = nome_tit;
            Saldo = 0;
        }

        public Conta(int num_conta, string nome_tit, double dep_inicial) : this(num_conta, nome_tit) {
            DepInicial = dep_inicial;
            Saldo = DepInicial;
        }

        public void Deposito(double deposito) {
            Saldo += deposito;
        }

        public void Saque(double saque) {
            Saldo -= (saque + 5.00);
        }

        public override string ToString() {
            return "Conta " + NumConta + ", Titular: " + NomeTit + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}

