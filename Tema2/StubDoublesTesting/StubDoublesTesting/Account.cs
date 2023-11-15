using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubDoublesTesting
{
    public class Account
    {
        private float balance;
        private string name;
        private float minBalance = 10;

        public Account()
        {
            balance = 0;
            name = string.Empty;
        }

        public Account(int value, string name)
        {
            balance = value;
            this.name = name;
            Console.WriteLine($"{name} balance is {balance}.");
        }

        public void Deposit(float amount)
        {
            balance += amount;
            Console.WriteLine($"New balance of {this.name} is {this.balance}.");
        }

        public void Withdraw(float amount)
        {
            balance -= amount;
            Console.WriteLine($"New balance of {this.name} is {this.balance}.");
        }

        public void TransferFunds(Account destination, float amount)
        {
            Console.WriteLine($"Transfering {amount} in destination: {destination.name}");
            destination.Deposit(amount);
            Withdraw(amount);
        }

        public Account TransferMinFunds(Account destination, float amount)
        {
            if (GetBalance - amount > GetMinBalance)
            {
                destination.Deposit(amount);
                Withdraw(amount);
            }
            else
            {
                throw new NotEnoughFundsException();
            }
            return destination;
        }

        internal void TransferFundsFromEurAmount_Version3(Account destination, Account source, float v, float rate, ICurrencyConvertor @object)
        {
            ICurrencyConvertor currencyConvertor = new CurrencyConvertorStub(rate);
            float amount = currencyConvertor.EurToRon(v, rate);
            destination.Deposit(amount);
            source.Withdraw(amount);
        }

        public float GetBalance
        {
            get { return balance; }
        }

        public float GetMinBalance
        {
            get { return minBalance; }
        }

        public string GetName
        {
            get { return name; }
        }
    }
}
