using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class ACipher: ICipher
    {
        public String Enecode(String s)
        {
            char[] arr = s.ToCharArray();
            s = "";
            foreach(char c in arr)
            {
                if (c >= 'а' && c <= 'я')
                    s += (char)(c + 1);
                else
                    s += c; 
              
            }
            return s;
        }

        public String Decode(String s)
        {
            char[] arr = s.ToCharArray();
            s = "";
            foreach(char c in arr)
            {
                if (c >= 'а' && c <= 'я')                   
                s += (char)('я' - c + 'а');
                else
                    s +=c;
            }

            return s;
        }
    }
}
