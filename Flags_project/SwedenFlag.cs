using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flags
{
    using System.Threading;
    class SwedenFlag : Shape
    {
        public SwedenFlag(string CountryName, int x, int y, ConsoleColor color1, ConsoleColor color2)
            : base(x, y)
        {
            this.color1 = color1;
            this.color2 = color2;
            this.CountryName = CountryName;
        }
        

        public override void Draw()

        // Закоментированные конструкции Thread.Sleep(5) можно раскомментировать для плавной отрисовки
        {
            //Не получилось вынести в отдельный метод.
            Console.SetCursorPosition(3, 0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Флаг: {0}", CountryName);

            while (X < 77 && Y < 21)
            {
                //Если в цикле указать условие i < 73 (как в остальных флагах), то правая сторона отрисовывается
                //почему-то на пиксель меньше, чем в других флагах.
                for (int i = 0; i <= 73; i++)
                {
                    if (Y <= 9)
                    {
                        if (i <= 20)
                        {
                            Engine.SetPixel(X++, Y, color1);
                        }
                        else if (i > 21 && i <= 25)
                        {
                            Engine.SetPixel(X++, Y, color2);
                        }
                        else if (i >= 26)
                        {
                            Engine.SetPixel(X++, Y, color1);
                        }
                        //Thread.Sleep(5); 
                    }

                    if (Y > 9 && Y <= 12)
                    {
                        //Дичайший костыль, без которого горизонтальная желтая полоса отрисовывается на пиксель больше,
                        //чем правая сторона флага. Чтобы от этого избавиться, я не придумал ничего лучше такого костыля.
                        while (i < 73)
                        {
                            Engine.SetPixel(X++, Y, color2);
                            //Thread.Sleep(5);
                            break;
                        }
                    }

                    if (Y >= 13)
                    {
                        if (i <= 20)
                        {
                            Engine.SetPixel(X++, Y, color1);
                        }
                        else if (i > 21 && i <= 25)
                        {
                            Engine.SetPixel(X++, Y, color2);
                        }
                        else if (i >= 26)
                        {
                            Engine.SetPixel(X++, Y, color1);
                        }
                        //Thread.Sleep(5);
                    }
                }
                if (Y <= 9)
                {
                    Engine.SetPixel(X = 3, Y++, color1);
                }
                else if (Y > 9 && Y <= 12)
                {
                    Engine.SetPixel(X = 3, Y++, color2);
                }
                else if (Y >= 13)
                {
                    Engine.SetPixel(X = 3, Y++, color1);
                }
                continue;
            }
            Thread.Sleep(1000);
        }

        private ConsoleColor color1;

        private ConsoleColor color2;

        private string CountryName;

    }

}

