using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flags
{
    class FranceFlag : ItalyFlag
    {
        public FranceFlag(string CountryName, int x, int y, ConsoleColor color1, ConsoleColor color2, ConsoleColor color3)
            : base(CountryName, x, y, color1, color2, color3)
        {
            this.color1 = color1;
            this.color2 = color2;
            this.color3 = color3;
            this.CountryName = CountryName;
        }

        private ConsoleColor color1;

        private ConsoleColor color2;

        private ConsoleColor color3;

        private string CountryName;
    }
}
