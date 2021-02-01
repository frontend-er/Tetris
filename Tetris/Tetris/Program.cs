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

            FirureGenerator generator = new FirureGenerator(20, 0, '*');
            Figure s = generator.GetNewFigure();
            s.Draw();
            Thread.Sleep(500);
            s.Hide();
            s.Rotate();
            s.Draw();   
            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.Down);
            s.Draw();
            Thread.Sleep(500);
            s.Hide();
            s.Rotate();
            s.Draw();
            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.Down);
            s.Draw();
            Thread.Sleep(500);
            s.Hide();
            s.Rotate();
            s.Draw();
            Thread.Sleep(500);
            s.Hide();
            s.Move(Direction.Down);
            s.Draw();
            Thread.Sleep(500);
            s.Hide();
            s.Rotate();
            s.Draw();
            Figure f = generator.GetNewFigure();
            f.Draw();
            Thread.Sleep(500);
            f.Hide();
            f.Rotate();
            f.Draw();
            Thread.Sleep(500);
            f.Hide();
            f.Move(Direction.Down);
            f.Draw();
            Thread.Sleep(500);
            f.Hide();
            f.Rotate();
            f.Draw();
            Thread.Sleep(500);
            f.Hide();
            f.Move(Direction.Down);
            f.Draw();
            Thread.Sleep(500);
            f.Hide();
            f.Rotate();
            f.Draw();
            Thread.Sleep(500);
            f.Hide();
            f.Move(Direction.Down);
            f.Draw();
            Thread.Sleep(500);
            f.Hide();
            f.Rotate();
            f.Draw();





            Console.ReadLine();

        }
    }
}
