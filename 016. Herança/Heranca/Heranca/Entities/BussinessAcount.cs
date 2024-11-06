namespace Heranca.Entities
{
    internal class BussinessAcount : Account
    {
        public double LoanLimit { get; set; }

        public BussinessAcount() { }

        //Abaixo temos uma forma de reaproveitar o construtor da SuperClasse 
        public BussinessAcount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

    }
}
