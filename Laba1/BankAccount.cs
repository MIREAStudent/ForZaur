using System;
using System.Text;

namespace Laba1
{
    class BankAccount
    {
        private int account;
        private int balance;
        private AccountType type;

        public int Account { get => account; set => account = value; }
        public int Balance { get => balance; set => balance = value; }
        public AccountType Type { get => type; set => type = value; }

    }


}
