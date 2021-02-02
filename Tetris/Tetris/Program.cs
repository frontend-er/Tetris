using System;
using System.Threading;

namespace Tetris
{
    class Program
    {

        static FirureGenerator generator;
        static void Main(string[] args)
        {

            Console.SetWindowSize(Field.Width, Field.Heigth);
            Console.SetBufferSize(Field.Width, Field.Heigth);


            Field.Heigth = 20;
            Field.Width = 30;



            generator = new FirureGenerator(20, 0, '*');
            Figure currentFigure = generator.GetNewFigure();


                 while (true)
                 {
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey();
                        var result = HandleKey(currentFigure, key.Key);
                        ProcessResult(result, ref currentFigure);
                    }
                 }
        }

        private static bool ProcessResult(Result result, ref Figure currentFigure)
        {
            if (result == Result.HEAP_STRIKE || result == Result.DOWN_BORDER_STRIKE)
            {
                Field.AddFigure(currentFigure);
                currentFigure = generator.GetNewFigure();
                return true;

            }
            else
                return false;
        }

        private static Result HandleKey(Figure currentFigure, ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    return currentFigure.TryMove(Direction.Left);
                case ConsoleKey.RightArrow:
                    return currentFigure.TryMove(Direction.Right);
                case ConsoleKey.DownArrow:
                    return currentFigure.TryMove(Direction.Down);
                case ConsoleKey.Spacebar:
                    return currentFigure.TryRotate();


            }
            return Result.SUCCESS; 
        }
    }
}
