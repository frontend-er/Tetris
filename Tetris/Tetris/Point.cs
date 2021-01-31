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
        }

        public Point(int a, int b, char symb)
        {
            x = a;
            y = b;
            c = symb;
        }
    }
}
