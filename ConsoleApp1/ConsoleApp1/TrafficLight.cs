using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TrafficLight
    {
        public int status = 0;
        public void PrintLight(int color)
        {
            if (color == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (color == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("*****");
            }
        }
  
        public void Draw()
        {
            
            while (true)
            {
                
                if (status == 3) status = 1;
                else status++;
                Console.Clear();
                if (status == 1)
                {
                    PrintLight(1);
                    PrintLight(0);
                    PrintLight(0);
                }
                else if (status == 2)
                {
                    PrintLight(0);
                    PrintLight(2);
                    PrintLight(0);
                }
                else if (status == 3)
                {
                    PrintLight(0);
                    PrintLight(0);
                    PrintLight(3);
                   

                }
               
                Thread.Sleep(2000);
                
            }
        }
    }
}
