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

        public override void Rotate(Point[] clone)
        {
            if (clone[0].X == clone[1].X)
                RotateToHorizontal(clone);
            else
                RotateToVertical(clone);
        }

        public void RotateToVertical(Point[] clone)
        {
            clone[1].X -= 1;
            clone[1].Y += 1;
            clone[2].X -= 2;
            clone[2].Y += 2;
            clone[3].X -= 3;
            clone[3].Y += 3;
        }

        public void RotateToHorizontal(Point[] clone)
        {
            clone[1].X += 1;
            clone[1].Y -= 1;
            clone[2].X += 2;
            clone[2].Y -= 2;
            clone[3].X += 3;
            clone[3].Y -= 3;
        }
    }
}
