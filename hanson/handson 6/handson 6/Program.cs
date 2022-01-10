using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson_6
{
    class Program
    {
            static void Main(string[] args)
            {
                int[] myArray = new int[] { 5, 6, 10, 12, 0 };
                int largest = int.MinValue;
                int second = int.MinValue;
                foreach (int i in myArray)
                {
                    if (i > largest)
                    {
                        second = largest;
                        largest = i;
                    }
                    else if (i > second)
                        second = i;
                }

                System.Console.WriteLine(second);
            Console.ReadLine();
            }
        }
    }

