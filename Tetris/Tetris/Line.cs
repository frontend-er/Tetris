using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Line
    {
        Point[] points = new Point[4];

        public Line (int x, int y, char c)
        {
            points[0] = new Point(x, y, c);
            points[1] = new Point(x + 1, y, c);
            points[2] = new Point(x + 2, y, c);
            points[3] = new Point(x + 3, y, c);
        }

        public void Draw ()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
    }
}
