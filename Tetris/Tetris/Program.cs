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
            Figure currentFigure = generator.GetNewFigure();


                 while (true)
                 {
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey();
                        HandleKey(currentFigure, key);
                    }
                    
                 }
            
            
        }

        private static void HandleKey(Figure currentFigure, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    currentFigure.TryMove(Direction.Left);
                    break;
                case ConsoleKey.RightArrow:
                    currentFigure.TryMove(Direction.Right);
                    break;
                case ConsoleKey.DownArrow:
                    currentFigure.TryMove(Direction.Down);
                    break;

            }
        }
    }
}
