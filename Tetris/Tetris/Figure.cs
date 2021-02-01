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
                if (p.x < 0 || p.y < 0 || p.x >= 40 || p.y >= 30)
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

        public abstract void Rotate();


    }
}
