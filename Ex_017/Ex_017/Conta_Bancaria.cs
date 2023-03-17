using System.Globalization;

namespace Ex_017
{
    internal class Conta_Bancaria
    {
        public int Numero_Conta { get; private set; }
        public string Nome_Conta { get; set; }
        public double Saldo_Conta { get; set; }
        

        public Conta_Bancaria(int numero_conta, string nome_conta, double saldo_conta ) {
            Numero_Conta = numero_conta;
            Nome_Conta = nome_conta;
            Saldo_Conta = saldo_conta;
        }

        public Conta_Bancaria (int numero_conta, string nome_conta) {
            Numero_Conta = numero_conta;
            Nome_Conta = nome_conta;
        }
        void Depositos(double depositos) {
            Saldo_Conta += depositos;
       
        }

        void Saque(double saque) {
            Saldo_Conta -= saque + 5;
        }


        public string Dados_da_conta() {
            return ($"Conta: {Numero_Conta}, Titular {Nome_Conta}, Saldo: $ {Saldo_Conta}");
        }
      



    }
}
