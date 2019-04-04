using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(39, 39);
            TrafficLight tl = new TrafficLight();
            Car car = new Car(tl);
            Thread t1 = new Thread(new ThreadStart(tl.Draw));
            t1.Start();
            Thread t2 = new Thread(new ThreadStart(car.Move));
            t2.Start();
        }
    }
}
