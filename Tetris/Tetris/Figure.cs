using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    abstract class Figure
    {
        const int numberPointsFigure = 4;
        public Point[] Points = new Point[numberPointsFigure];

        public void Draw()
        {
            foreach (Point p in Points)
            {
                p.Draw();
            }
        }

        public void Hide ()
        {
            foreach (Point p in Points)
            {
                p.Hide();
            }
        }

        public Result TryMove(Direction dir)
        {
            Hide();
            var clone = Clone();
            Move(clone,dir);

            var result = VerifyPosition(clone);
            if (result == Result.SUCCESS) 
                Points = clone;
            Draw();
            return result;
        }

        private Result VerifyPosition(Point[] clone)
        {
            foreach(var p in clone)
            {
                if (p.Y >= Field.Heigth)
                    return Result.DOWN_BORDER_STRIKE;
                else if (p.X >= Field.Width || p.X < 0 || p.Y < 0)
                    return Result.BORDER_STRIKE;
                else if (Field.CheckStrike(p))
                    return Result.HEAP_STRIKE;

            }
            return Result.SUCCESS;
        }

        public void Move(Point[] clone, Direction dir)
        {
            foreach (var p in clone)
            {
                p.Move(dir);
            }
        }

        private Point[] Clone()
        {
            var newPoints = new Point[numberPointsFigure];
            for (int i = 0; i < numberPointsFigure; i++)
            {
                newPoints[i] = new Point(Points[i]);

            }
            return newPoints;
        }

        internal Result TryRotate()
        {
            Hide();
            var clone = Clone();
            Rotate(clone);

            var result = VerifyPosition(clone);
            if (result == Result.SUCCESS)
                Points = clone;


            Draw();

            return result;
        }

        public abstract void Rotate(Point[] clone);


    }
}
