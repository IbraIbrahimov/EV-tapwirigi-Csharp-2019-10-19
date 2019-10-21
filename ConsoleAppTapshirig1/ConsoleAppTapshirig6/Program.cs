using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTapshirig6
{
    class Program
    {
        static void Main(string[] args)
        {   /*4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir.*/
            Console.WriteLine("4 reqemli eded daxil edin");

            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int num1 = num;
            while (num>0)
            {
                 
                count++;
                num /= 10;
                
            }
            double result = 7 * Math.Pow(10, count) + num1;
             result = (result * 10) + 8;
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
