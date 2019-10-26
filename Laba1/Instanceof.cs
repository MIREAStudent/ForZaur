using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Instanceof
    {
        public static bool Instance(Object obj)
        {
            if (obj is System.IFormattable)
                return true;
            else
                return false;
        }


    }
}
