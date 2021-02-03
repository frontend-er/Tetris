using System;
using System.Threading;
using System.Timers;

namespace Tetris
{
    class Program
    {
        const int TIMER_INTERVAL = 500;
        static System.Timers.Timer aTimer;

        static private Object _lockObject = new object(); 

        static FirureGenerator generator;
        static Figure currentFigure;


        static void Main(string[] args)
        {

            Console.SetWindowSize(Field.Width, Field.Heigth);
            Console.SetBufferSize(Field.Width, Field.Heigth);

            generator = new FirureGenerator(Field.Width/2, 0, Drawer.DEFAULT_POINT);
            currentFigure = generator.GetNewFigure();
            SetTimer();



            Test();


            while (true)
                 {
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey();
                        Monitor.Enter(_lockObject);
                        var result = HandleKey(currentFigure, key.Key);
                        ProcessResult(result, ref currentFigure);
                        Monitor.Exit(_lockObject);

                }
            }
        }

        private static void Test()
        {
            DrawerProvider.Drawer.DrawPoint(4, 5);
        }

        private static void SetTimer()
        {
            aTimer = new System.Timers.Timer(TIMER_INTERVAL);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }


        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Monitor.Enter(_lockObject);
            var result = currentFigure.TryMove(Direction.Down);
            ProcessResult(result, ref currentFigure);
            Monitor.Exit(_lockObject);

        }

        private static bool ProcessResult(Result result, ref Figure currentFigure)
        {
            if (result == Result.HEAP_STRIKE || result == Result.DOWN_BORDER_STRIKE)
            {

                Field.AddFigure(currentFigure);
                Field.TryToDeleteLine();

                if(currentFigure.IsOnTop())
                {
                    WriteGameOver();
                    aTimer.Elapsed -= OnTimedEvent;
                    return true;
                }
                else
                {

                    currentFigure = generator.GetNewFigure();
                    return true;
                }


            }
            else
                return false;
        }

        private static void WriteGameOver()
        {
            Console.SetCursorPosition(Field.Width / 2 - 8, Field.Heigth / 2);
            Console.WriteLine("G A M E  O V E R");
            Console.SetCursorPosition(0, 0);

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
