using Course.Entities;

namespace Course.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void withdraw(double amount)// Reimplementando a Função da Classe Account
        {
            base.withdraw(amount); //utilizando a lógica que já existia em Account com a palavra Base.
            Balance -= 2.0;
        }

    }
}
