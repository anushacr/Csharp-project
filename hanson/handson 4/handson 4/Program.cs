using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = "Welcome to CSharp Program ".
                                         Split(' ');
            string ans = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                ans += s[i] + " ";
            }
            Console.Write("Reversed String:\n");
            Console.Write(ans.Substring(0, ans.Length - 1));
            Console.ReadLine();
        }
    }
}
