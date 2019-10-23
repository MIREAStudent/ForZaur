using System;
using System.Text;

namespace Laba1
{
    class BankAccount
    {
        private int account;
        static private int globalAccount = 1000;
        private int balance;
        private AccountType type;

        
        public int Account { get => account; }
        public int Balance { get => balance; set => balance = value; }
        public AccountType Type { get => type; set => type = value; }

        public BankAccount()
        {
            account = globalAccount;
            incGlobalAccount();
        }

        private void incGlobalAccount()
        {
            globalAccount += 10;
        }

        public void pullAccount(int sum)
        {
            if (this.balance > sum)
                this.balance -= sum;
            else
                Console.WriteLine("Недостаточно средств");
        }

        public void pushAccount(int sum)
        {
            this.balance += sum;
        }

    }


}
