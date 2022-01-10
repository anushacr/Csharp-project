using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            while (input.Length>0)
            {
                Console.WriteLine(input[0] + "-");
                int temp = 0;
                for (int i = 0; i < input.Length; i++) 
                if (input[0] == input[i])
                {
                        temp++;
                }
            
            Console.WriteLine(temp);
            input = input.Replace(input[0].ToString(), string.Empty);
                Console.ReadLine();
        }
    }
}
}
