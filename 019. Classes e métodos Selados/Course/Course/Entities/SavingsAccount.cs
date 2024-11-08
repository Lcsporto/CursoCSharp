using Course.Entities;

namespace Course.Entities
{
    internal /*sealed*/ class SavingsAccount : Account //Selamos a classe para não poder ter nenhuma Subclasse advinda dela.
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

        public sealed override void withdraw(double amount)// Agora essa opeação não pode ser sobrescrita novamente em outra SubClasse
        {
            base.withdraw(amount);
            Balance -= 2.0;
        }

    }
}
