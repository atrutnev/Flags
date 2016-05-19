using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flags
{
    using System.Threading;

    class ItalyFlag : Shape
    {
        public ItalyFlag(string CountryName, int x, int y, ConsoleColor color1, ConsoleColor color2, ConsoleColor color3)
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
                //А здесь потребовалось указать i <= 74, чтобы граница флага совпадала с другими.
                for (int i = 0; i <= 74; i++)
                {
                    if (i <= 23)
                    {
                        Engine.SetPixel(X++, Y, color1);
                    }
                    else if (i > 24 && i <= 49)
                    {
                        Engine.SetPixel(X++, Y, color2);
                    }
                    else if (i > 50)
                    {
                        Engine.SetPixel(X++, Y, color3);
                    }
                }
                Engine.SetPixel(X = 3, Y++, color1);
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
