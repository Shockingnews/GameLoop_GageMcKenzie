using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameLoop_GageMcKenzie
{
    internal class Program
    {
        static int xPos = 0;
        static int yPos = 0;
        static int sharkYPos = 0;
        static int sharkXPos = 0;

        static int xinput = 0;
        static int yinput = 0;

        static bool Alive = true;


        static void Main(string[] args)
        {
            while (Alive)
            {
                PlayerInput();
                Update();
                Draw();
                map();
                Thread.Sleep(17);
            }

        }
        static void PlayerInput()
        {
            xinput = 0;
            yinput = 0;

            if (!Console.KeyAvailable)
            {
                return;
            }

            ConsoleKeyInfo input = Console.ReadKey(true);

            if (input.Key == ConsoleKey.S)
            {
                yinput += 1;
            }

            if (input.Key == ConsoleKey.W)
            {
                yinput -= 1;
            }

            if (input.Key == ConsoleKey.A)
            {
                xinput -= 1;
            }

            if (input.Key == ConsoleKey.D)
            {
                xinput += 1;
            }
        }

        static void Update()
        {
            
            yPos += yinput;
            xPos += xinput;
            if(yPos == -1)
            {
                yPos = 0;
            }
            if (xPos == -1)
            {
                xPos = 0;
            }
            if (xPos == 14)
            {
                xPos -= 1;
            }
            if (yPos == 6)
            {
                yPos -= 1;
            }
        }

        static void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            map();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(xPos, yPos);
            Console.Write('o');
            sharkmovement();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(sharkXPos, sharkYPos);
            Console.Write('^');

        }

        static void map()
        {
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("              ");
            Console.WriteLine("              ");
            Console.WriteLine("              ");
            Console.WriteLine("              ");
            Console.WriteLine("              ");
            Console.WriteLine("              ");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static void sharkmovement()
        {
            sharkYPos = 4;
            sharkYPos = 4;

            if(sharkYPos < yPos)
            {
                sharkYPos += 1;
            }
            if (sharkYPos > yPos)
            {
                sharkYPos -= 1;
            }
            if (sharkXPos > xPos)
            {
                sharkXPos -= 1;
            }
            if (sharkXPos < xPos)
            {
                sharkXPos += 1;
            }
        }

    }
}

