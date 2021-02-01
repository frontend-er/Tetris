using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    abstract class Figure
    {
        const int numberPointsFigure = 4;
        protected Point[] points = new Point[numberPointsFigure];

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }

        public void Hide ()
        {
            foreach (Point p in points)
            {
                p.Hide();
            }
        }

        public void TryMove(Direction dir)
        {
            Hide();
            var clone = Clone();
            Move(clone,dir);

            if (VerifyPosition(clone)) 
                points = clone;


            Draw();
        }

        private bool VerifyPosition(Point[] clone)
        {
            foreach(var p in clone)
            {
                if (p.X < 0 || p.Y < 0 || p.X >= Field.Width || p.Y >= Field.Heigth)
                    return false;

            }
            return true;
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
                newPoints[i] = new Point(points[i]);

            }
            return newPoints;
        }

        internal void TryRotate()
        {
            Hide();
            var clone = Clone();
            Rotate(clone);

            if (VerifyPosition(clone))
                points = clone;


            Draw();
        }

        public abstract void Rotate(Point[] clone);


    }
}
