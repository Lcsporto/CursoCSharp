using Course.Exceptions;
using System.Globalization;

namespace Course.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (balance < 0)
            {
                throw new AccountException("Balance must be equal or higger than zero");
            }

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }


        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new AccountException("The amount exceeds withdraw limit");
            }

            if (amount > Balance)
            {
                throw new AccountException("Not enough balance");
            }



            Balance -= amount;
        }

        public override string ToString()
        {
            return "New Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
