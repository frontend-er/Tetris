using System;
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
            Draw();
        }

        public override void Rotate()
        {
            if (points[0].x == points[1].x)
                RotateToHorizontal();
            else
                RotateToVertical();
        }

        public void RotateToVertical()
        {
            points[1].x -= 1;
            points[1].y += 1;
            points[2].x -= 2;
            points[2].y += 2;
            points[3].x -= 3;
            points[3].y += 3;
        }

        public void RotateToHorizontal()
        {
            points[1].x += 1;
            points[1].y -= 1;
            points[2].x += 2;
            points[2].y -= 2;
            points[3].x += 3;
            points[3].y -= 3;
        }
    }
}
