using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);


            Point p1 = new Point(3, 2 , '*');
            p1.Draw();

            Point p2 = new Point(3, 3, '*');
            p2.Draw();

            Console.ReadLine();

        }
    }
}
