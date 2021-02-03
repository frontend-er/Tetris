using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Line : Figure
    {
        public Line (int x, int y, char c)
        {
            Points[0] = new Point(x, y, c);
            Points[1] = new Point(x, y + 1, c);
            Points[2] = new Point(x, y + 2, c);
            Points[3] = new Point(x, y + 3, c);
            Draw();
        }

        public override void Rotate()
        {
            if (Points[0].X == Points[1].X)
                RotateToHorizontal();
            else
                RotateToVertical();

        }

        public void RotateToVertical()
        {
            Points[1].X -= 1;
            Points[1].Y += 1;
            Points[2].X -= 2;
            Points[2].Y += 2;
            Points[3].X -= 3;
            Points[3].Y += 3;
        }

        public void RotateToHorizontal()
        {
            Points[1].X += 1;
            Points[1].Y -= 1;
            Points[2].X += 2;
            Points[2].Y -= 2;
            Points[3].X += 3;
            Points[3].Y -= 3;
        }
    }
}
