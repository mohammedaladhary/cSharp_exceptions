using System;
namespace Exceptions
{
    public class insuffiecntFunds : ApplicationException
    {
        public insuffiecntFunds() { }

        public insuffiecntFunds(string message) : base(message) { }
    }


    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal initAmount)
        {
            balance = initAmount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                throw new insuffiecntFunds("Insufficient fund.");
            }
            else
            {
                Console.WriteLine($"Withdrawal of {amount} successful");
            }
        }
    }
}