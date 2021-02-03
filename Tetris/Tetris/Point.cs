using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char C { get; set; }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(C);
            Console.SetCursorPosition(0, 0);

        }

        public Point(int a, int b, char symb)
        {
            X = a;
            Y = b;
            C = symb;
        }

        public Point(Point point)
        {
            this.X = point.X;
            this.Y = point.Y;
            this.C = point.C;

        }

        internal void Hide()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
        }

        internal void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.Down:
                    Y += 1;
                    break;
                case Direction.Left:
                    X -= 1;
                    break;
                case Direction.Right:
                    X += 1;
                    break;
                case Direction.Up:
                    Y -= 1;
                    break;

            }
        }
    }
}
