using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laba1
{
    class BankTransaction
    {
      private DateTime date;
      private int sum;
        private String path = "C:\\Лабы CSharp\\Laba1\\transactions.txt";
        public BankTransaction(int sum)
        {
            this.date = DateTime.Now;
            this.sum = sum; 
        }

        public DateTime Date { get => date;}
        public int Sum { get => sum; }

        private String Data()
        {
            return this.sum + " " + this.date;
        }

        public void Dispose()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(this.Data());                   
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("такого файла не существует");
            }
         //   GC.SuppressFinalize(this); 

        }
    }
}
