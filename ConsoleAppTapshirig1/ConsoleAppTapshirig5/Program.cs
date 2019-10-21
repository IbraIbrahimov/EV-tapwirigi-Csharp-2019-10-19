using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTapshirig5
{
    class Program
    {  /*1-1000 qeder ederlerin icerisinde 
    11-e bolunub reqemleri cemi 11-den boyuk olan 11-ci eded hansidir?*/
        static void Main(string[] args)
        {
            int count=0 ;
            
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
               
                int j = i;
                while (j>0)
                {
                    sum += j % 10;
                    j /= 10;

                 }
                if (sum > 11 && i % 11 == 0)
                {
                    count++;
                    
                    if (count == 11)
                    {
                        Console.WriteLine(i);
                    }

                }

                sum = 0;

            }
             
            //Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
