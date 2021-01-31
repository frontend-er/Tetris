﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Line : Figure
    {
        public Line (int x, int y, char c)
        {
            points[0] = new Point(x, y, c);
            points[1] = new Point(x, y + 1, c);
            points[2] = new Point(x, y + 2, c);
            points[3] = new Point(x, y + 3, c);
        }
    }
}
