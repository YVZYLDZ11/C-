using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int xm, ym, x, y, r;
            char c;
            Random rnd = new Random();
            xm = 60; ym = 15; r = 15;
            for (r = 0; r <= 15; r++)
            {
                for (int i = 0; i <= 360; i= i+10)
                {
                    x = (int)(xm +r * Math.Sin(i * Math.PI / 100));
                    y = (int)(ym + r * Math.Cos(i * Math.PI / 100));

                    c = (char)rnd.Next(64,256);
                    Console.SetCursorPosition(x,y);
                    Console.ForegroundColor = ((ConsoleColor)rnd.Next(0, 16));
                    Console.Write(rnd.Next(0, 10));
                    System.Threading.Thread.Sleep(100);
                }
                System.Threading.Thread.Sleep(100);
            }
            Console.ReadLine();
           
        }
       
    }
}
