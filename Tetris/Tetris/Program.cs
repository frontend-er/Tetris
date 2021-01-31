using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Square s = new Square(7, 8, '*');
            s.Draw();

            Line l = new Line(1, 1, '*');
            l.Draw();

          

            Console.ReadLine();

        }
    }
}
