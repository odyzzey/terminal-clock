﻿using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawBorder();
            Console.ReadKey();
        }

        static void DrawSmallTime()
        {

        }

        static void DrawBorder()
        {
            //get width and height of console
            var w = Console.WindowWidth;
            var h = Console.WindowHeight;

            for (int i = 2; i <= h; i++) //Starting at 2 because that's where the ceiling will be
            {
                Console.SetCursorPosition(0, i); //or not?
                if(i == 2 || i == h) //At the bottom and the top create a border
                {
                    for(int z = 1; z <= w; z++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    //Drawing the side borders
                    Console.SetCursorPosition(0, i);
                    Console.Write("*");
                    Console.SetCursorPosition(w-1, i);
                    Console.Write("*");
                }
            }
        }
    }
}