using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTapshirig7
{
    class Program
    {    /*verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3*/
        static void Main(string[] args)
        {
            Console.WriteLine("6 reqemli eded daxil edin");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            
            while (num > 0)
            {
                if (num / 1000 == 0)
                {
                    sum += num % 10;
                }
                
                num /= 10;
                
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
