using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Reverse
    {
        public static String reverse(String s)
        {
            String result = String.Empty;
            char[] charArray = s.ToCharArray(); 

            for(int i = charArray.Length - 1; i >= 0; i--)
            {
                result += charArray[i]; 
            }

            return result;
        }

    }
}
