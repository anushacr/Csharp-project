using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson22
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr, rev;
            myStr = "parvathi";
            rev = "";
            Console.WriteLine("String is " + myStr);
            int len;
            len = myStr.Length - 1;
            while (len >= 0)
            {
                rev = rev + myStr[len];
                len--;
            }
            Console.WriteLine("Reversed String is " + rev);
            Console.ReadLine();
        }
    }
}
        