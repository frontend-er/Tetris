using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Point
    {
        public int x = 0;
        public int y = 0;
        public char c;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
