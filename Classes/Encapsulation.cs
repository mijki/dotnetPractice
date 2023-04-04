namespace dotnetPractice.Classes
{
    public class Encapsulation
    {
        public class BankAccount
        {
            private decimal balance;

            public decimal GetBalance()
            {
                return balance;
            }

            public void Deposit(decimal amount)
            {
                balance += amount;
            }

            public void Withdraw(decimal amount)
            {
                if (amount > balance)
                    throw new ArgumentException("Insufficient balance");
                balance -= amount;
            }
        }
    }
}