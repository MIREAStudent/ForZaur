using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Laba1
{
    class BankAccount
    {
        private int account;
        static private int globalAccount = 1000;
        private int balance;
        private AccountType type;
       private Queue<BankTransaction> transactions = new Queue<BankTransaction>(); 

        public int Account { get => account;  }
        public static int GlobalAccount { get => globalAccount;  }
        public int Balance { get => balance; }
        internal AccountType Type { get => type; }
        internal Queue<BankTransaction> Transactions { get => transactions; }

        public BankAccount()
        {
            incGlobalAccount();
        }

        public BankAccount(AccountType type)
        {
            this.type = type; 
            incGlobalAccount();
        }

        public BankAccount(int balance)
        {
            this.balance = balance;
            incGlobalAccount();
        }

        public BankAccount(AccountType type, int balance)
        {
            this.type = type;
            this.balance = balance;
            incGlobalAccount();
        }

        private void incGlobalAccount()
        {
            this.account = globalAccount; 
            globalAccount += 10;
        }

        public void PullAccount(int sum)
        {
            if (this.balance > sum)
            {
                this.balance -= sum;
                transactions.Enqueue(new BankTransaction(sum));

            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
        }

        public void PushAccount(int sum)
        {
            this.balance += sum;
            transactions.Enqueue(new BankTransaction(sum)); 
        }

        public void GetMoney(BankAccount account, int money)
        {
            if (account != this)
            {
                if (account.balance >= money)
                {
                    account.balance -= money;
                    this.balance += money;

                }
                else
                {
                    Console.WriteLine("Недостаточно средств для перевода");
                }
            }
            else
            {
                Console.WriteLine("Попытка перевести средтсва самому себе");
            }

        }


    }


}
