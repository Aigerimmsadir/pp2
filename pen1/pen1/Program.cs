using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace pen1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(39, 30);  
            Pen p = new Pen();
            Thread t1 = new Thread(new ThreadStart(p.Draw));
            t1.Start();
        }
    }
}
