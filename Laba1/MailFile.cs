using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class MailFile
    {
        private static String mailFilePath = "C:\\Лабы CSharp\\Laba1\\mailusers.txt";
        public void MailSet(String path)
        {
            

            String[] lines = GetLines(path);

            FileStream file = new FileStream(mailFilePath, FileMode.Create);
            StreamWriter writer = new StreamWriter(file);


            foreach (String str in lines)
            {
                string s = str;
                SearchMail(ref s);
                
                writer.WriteLine(s);
                
            }

            writer.Close();

        }

        public void SearchMail(ref string s)
        {
            String[] array = s.Split('#');
            s = array[1];
        }
        static String[] GetLines(String path)
        {
            try
            {
                return File.ReadAllLines(path);
            }catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.ToString()); 
                return null; 
            }
           
           
        } 
    }
}
