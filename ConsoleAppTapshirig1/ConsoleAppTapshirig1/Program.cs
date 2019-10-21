using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTapshirig1
{
    class Program

    /* 1-1000 qeder ededlerin icerisinde hem 7-e, hemde 8-e bolunenlerin siyahisi*/
    {
        static void Main(string[] args)
        {
           

            for (int i = 1; i < 1000; i++)
            {
                if (i % 7 == 0 && i%8==0)
                {
                    Console.WriteLine($"1-1000 qeder hem 7-e hemde 8-e bolunen ededler: {i}");
                }

            }
            
            Console.ReadKey();
        }
    }
}
