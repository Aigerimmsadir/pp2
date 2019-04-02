using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pen1
{
    class Pen
    {
        public char sign = '#';
        public int x, y;
        public Pen()
        {
            x = 0;
            y = 10;
        }
        public void Draw()
        {
            bool isRed = false;
            while(true){
                Console.SetCursorPosition(x, y);
                if (isRed)
                {
                    Console.ForegroundColor = ConsoleColor.Red; 
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                Console.Write(sign);

                if (x == 39)
                {
                    x = 0;
                    isRed = !isRed;
                }
                else x++;
                Thread.Sleep(100);
            }
        }
    }
}
