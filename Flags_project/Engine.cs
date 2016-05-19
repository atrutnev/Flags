using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flags
{
    using System.Threading;
    static class Engine
    {

        public static void Clean()
        {
            Console.Clear();
        }

        public static void SetPixel(int x, int y, ConsoleColor color = ConsoleColor.White)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write("█");
        }

        public static void Draw(List<Shape> shapes)
        {
            //Engine.Clean();
            
            foreach (var shape in shapes)
            {
                Engine.Clean();
                Area.LoadField();
                shape.Draw();
            }
            Thread.Sleep(100);
            Engine.Clean();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Продемонстрировано {0} флага(ов)\n", shapes.Count);
            Console.WriteLine("Работа программы закончена.");
            Console.ReadLine();
            
        }
    }
}
