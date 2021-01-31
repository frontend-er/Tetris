using System;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Square s = new Square(3,3, '*');
            s.Draw();

            Thread.Sleep(500);

            s.Hide();
            s.Move(Direction.Right);
            s.Draw();
            s.Hide();
            s.Move(Direction.Right);
            s.Draw();
            s.Hide();
            s.Move(Direction.Down);
            s.Draw();
            s.Hide();
            s.Move(Direction.Right);
            s.Draw();
            s.Hide();
            s.Move(Direction.Right);
            s.Draw();


            Console.ReadLine();

        }
    }
}
