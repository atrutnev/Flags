using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flags
{
    using System.Threading;

    //Обозначаем границы поля, в котором будут выводиться изображения флагов
    static class Area
    {

        static char[,] field = new char[22, 77];

        
        public static void LoadField()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(1, 1);
            for (int i = 0; i < 77; i++)
            {
                Console.Write('X');
                field[0, i] = 'X';
            }
            Console.SetCursorPosition(1, 22);
            for (int i = 0; i < 77; i++)
            {
                Console.Write('X');
                field[21, i] = 'X';
            }
            for (int i = 2; i < 22; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write('X');
                field[i - 1, 0] = 'X';
                Console.SetCursorPosition(77, i);
                Console.Write('X');
                field[i - 1, 76] = 'X';
            }

            //Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
