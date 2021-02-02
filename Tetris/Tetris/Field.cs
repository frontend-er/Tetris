using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    static class Field
    {
        private static int _width = 40;
        private static int _height = 30;


        public static int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
                Console.SetWindowSize(Field._width, Field.Heigth);
                Console.SetBufferSize(Field._width, Field.Heigth);
            }
        }

        public static int Heigth
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
                Console.SetWindowSize(value, Field.Heigth);
                Console.SetBufferSize(value, Field.Heigth);
            }
        }


        private static bool[][] _heap;

        static Field()
        {
            _heap = new bool[Heigth][];
            for (int i = 0; i < Heigth; i++)
            {
                _heap[i] = new bool[Width];
            }
        }

        public static bool CheckStrike(Point p)
        {
            return _heap[p.X][p.Y];
        }

        public static void AddFigure(Figure fig)
        {
            foreach (var p in fig.Points)
            {
                _heap[p.X][p.Y] = true;
            }
        }

    }


}
