using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTapshirig3
{
    class Program
    {    /* 1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
     hemin ededin daxilinde 3 reqemi umumiyyetle olmasin*/
        static void Main(string[] args)
        {
            int j;
            
            for (int i = 1; i < 1000; i++)
            {
                j = i;
                bool is3 = false;
                while (j>0 && !is3)
                {
                    if (j % 10 == 3 )
                    {
                        is3 = true;
                    }
                     j /= 10;
                 }
                if (!is3)
                {
                    Console.WriteLine(i);
                }
               
        
            }
            
            Console.ReadKey();
        }
            
        } 
    }

