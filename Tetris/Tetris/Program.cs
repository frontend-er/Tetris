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
            Figure s = null;


            while (true)
            {
                FigureFall(s,generator);
                s.Rotate();
               
            }
            
            static void FigureFall(Figure figure, FirureGenerator figGen)
            {
                figure = figGen.GetNewFigure();
                figure.Draw();
                for (int i = 0; i < 20; i++)
                {
                    figure.Hide();
                    figure.Move(Direction.Down);
                    figure.Draw();
                    Thread.Sleep(750);
                }
            }





            Console.ReadLine();

        }
    }
}
