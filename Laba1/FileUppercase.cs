using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 
namespace Laba1
{
    class FileUppercase
    {
       public static void UpperTextInFile(String path)
        {
         String text = GetTextFile(path);

            SendText(path,text.ToUpper()); 

        }

       public static String GetTextFile(String path)
        {
            try
            {
                FileStream file = new FileStream(path, FileMode.Open);
                StreamReader reader = new StreamReader(file);
                String fileText = reader.ReadToEnd();
                reader.Close();
                return fileText;
            } catch(Exception e)
            {
                Console.WriteLine("такого файла не существует");
                return String.Empty; 
            }
        }
        public static void SendText(String path, String text)
        {
            try
            {
                FileStream file = new FileStream(path, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(text);
                writer.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("такого файла не существует");
            }
        }

    }
}
