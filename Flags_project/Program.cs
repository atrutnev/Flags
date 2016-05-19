using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flags
{
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new RusFlag("Российская Федерация", 3, 3, ConsoleColor.White, ConsoleColor.Blue, ConsoleColor.Red));
            shapes.Add(new GermanFlag("Германия", 3, 3, ConsoleColor.DarkGray, ConsoleColor.Red, ConsoleColor.Yellow));
            shapes.Add(new SwedenFlag("Швеция", 3, 3, ConsoleColor.Blue, ConsoleColor.Yellow));
            shapes.Add(new ItalyFlag("Италия", 3, 3, ConsoleColor.Green, ConsoleColor.White, ConsoleColor.Red));
            shapes.Add(new FranceFlag("Франция", 3, 3, ConsoleColor.Blue, ConsoleColor.White, ConsoleColor.Red));
            shapes.Add(new DenmarkFlag("Дания", 3, 3, ConsoleColor.Red, ConsoleColor.White));

            Engine.Draw(shapes);  
        }
    }
}    

    

    

