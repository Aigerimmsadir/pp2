using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        TrafficLight tl;
        char sign = '#';
        int x, y;
        public Car(TrafficLight tl)
        {
            this.tl = tl;
            x = 0;
            y = 20;
        }
        void Clear()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }
        public void Move()
        {
            while (true)
            {

                if (tl.status == 3)
                {
                    Clear();
                    if (x == 38) x = 0;
                    else x++;
                }
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(sign);

                Thread.Sleep(100);
            }
        }
    }
}
