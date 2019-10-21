using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTapshirig8
{
    class Program
    {  /*verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati*/
        static void Main(string[] args)
        {
            Console.WriteLine("5 reqemli eded daxil edin");
            int num = int.Parse(Console.ReadLine());
            
            int sum = 0;
            int LastNum = num%10;
            int FirstNum = num;
            while (num >= 10)
            {
                num =num/ 10;

            }
            FirstNum = num;
            sum = FirstNum + LastNum;
            double result = Math.Pow(sum, 2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
