﻿using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Figure[] f = new Figure[2];
            f[0] = new Square(7, 8, '*');
            f[1] = new Line(1, 1, '*');


            foreach (Figure fig in f)
            {
                fig.Draw();
            }


            Console.ReadLine();

        }
    }
}
