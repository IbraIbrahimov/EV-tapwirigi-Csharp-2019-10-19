using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTapshirig2
{
    class Program
    {   /* 1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
	hem reqemleri cemi 5-e bolunsun, 
	hem de ozu 5-e bolunsun*/
        static void Main(string[] args)
        {
            int sumNumbers = 0;
            
            int j;
            for (int i = 1; i < 1000; i++)
            {
                j = i;
                while (j>0)
                {
                    sumNumbers += j % 10;
                    j = j / 10;
                }
                if (sumNumbers %5==0 && i%5==0)
                {
                    Console.WriteLine(i);
                }
                sumNumbers = 0;
            }
            Console.ReadKey();
        }
    }
}
