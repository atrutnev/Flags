using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flags
{
    using System.Threading;
    class RusFlag : Shape
    {
        public RusFlag(string CountryName, int x, int y, ConsoleColor color1, ConsoleColor color2, ConsoleColor color3)
            : base(x, y)
        {
            this.color1 = color1;
            this.color2 = color2;
            this.color3 = color3;
            this.CountryName = CountryName;
        }

        public override void Draw()
        {
            //Не получилось вынести в отдельный метод.
            Console.SetCursorPosition(3, 0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Флаг: {0}", CountryName);

            while (X < 77 && Y < 21)
            {
                for (int i = 0; i < 73; i++)
                {
                    if (Y <= 8)
                    {
                        Engine.SetPixel(X++, Y, color1);
                    }
                    else if (Y > 8 && Y <= 14)
                    {
                        Engine.SetPixel(X++, Y, color2);
                    }
                    else if (Y >= 15)
                    {
                        Engine.SetPixel(X++, Y, color3);
                    }
                    //Thread.Sleep(5);  
                }
                if (Y <= 8)
                {
                    Engine.SetPixel(X = 3, Y++, color1);
                }
                else if (Y > 8 && Y <= 14)
                {
                    Engine.SetPixel(X = 3, Y++, color2);
                }
                else if (Y >= 15)
                {
                    Engine.SetPixel(X = 3, Y++, color3);
                }

                continue;
            }
            Thread.Sleep(1000);
        }

        private ConsoleColor color1;

        private ConsoleColor color2;

        private ConsoleColor color3;

        private string CountryName;


    }
}
