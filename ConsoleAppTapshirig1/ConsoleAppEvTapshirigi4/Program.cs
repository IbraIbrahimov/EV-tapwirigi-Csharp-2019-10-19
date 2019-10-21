using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEvTapshirigi4
{
    class Program
    {   /*1-1000 qeder ederlerin icerisinden,
    daxilinde 3 reqemi olmayib,
    reqemleri cemi 3 olan en sonuncu eded hansidir?*/
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            int EndNum = 0;
            for (int i = 1; i < 1000; i++)
            {
                bool is3 = false;
                int j = i;
                while (j>0)
                {
                    if (j % 10 == 3)
                    {
                        is3 = true;
                    }
                    sum += j % 10;
                    j /= 10;
                }
                if (sum == 3 && !is3 )
                {
                    count++;

                    EndNum = i;
                }
               
                sum = 0;
            }
            Console.WriteLine(EndNum);
            Console.ReadKey();

        }
    }
}
