using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public class Point
    {
        public int x = 0;
        public int y = 0;
        public char c;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
            Console.SetCursorPosition(0, 0);

        }

        public Point(int a, int b, char symb)
        {
            x = a;
            y = b;
            c = symb;
        }

        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
            this.c = point.c;

        }

        internal void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }

        internal void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.Down:
                    y += 1;
                    break;
                case Direction.Left:
                    x -= 1;
                    break;
                case Direction.Right:
                    x += 1;
                    break;

            }
        }
    }
}
