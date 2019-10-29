using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class BankTransaction
    {
      private DateTime date;
      private int sum; 

        public BankTransaction(int sum)
        {
            this.date = DateTime.Now;
            this.sum = sum; 
        }

        public DateTime Date { get => date;}
        public int Sum { get => sum; }
    }
}
