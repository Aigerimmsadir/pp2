using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrafficLight
{
    class Program
    {
        static void print(int n)
        {
            string s = "******";
            for(int i = 0;i < n; i++)
            {
                Console.WriteLine(s);
            }
        }
        public static void light()
        {
            int cnt = 0;
            int x = 0;
            int y = 20;
            while (true)
            {
                Console.Clear();
                if(cnt == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    print(5);
                    Console.ForegroundColor = ConsoleColor.White;
                    print(10);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(x, y);
                    print(1);
                }
                else if(cnt == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    print(5);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    print(5);
                    Console.ForegroundColor = ConsoleColor.White;
                    print(5);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(x, y);
                    print(1);
                }
                else if(cnt == 2 || cnt ==3 || cnt ==4)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    print(10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    print(5);
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.White;
                    print(1);
                    x += 10; 
                }
                cnt++;

                cnt %= 5;
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Thread thread = new Thread(light);
            thread.Start();
            
        }
    }
}
