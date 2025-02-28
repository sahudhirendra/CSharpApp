using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class PassByRef
    {
        public static void Addition(out int i)
        {
            i = 30;
            //i += i;
        }
        public static void Addition1(ref int i)
        {
            //i = 30;
            i += i;
        }
    }
}
