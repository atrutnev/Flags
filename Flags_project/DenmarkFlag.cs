using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flags
{
    class DenmarkFlag : SwedenFlag
    {
        public DenmarkFlag(string CountryName, int x, int y, ConsoleColor color1, ConsoleColor color2)
            : base(CountryName, x, y, color1, color2)
        {
            this.color1 = color1;
            this.color2 = color2;
            this.CountryName = CountryName;
        }

        private ConsoleColor color1;

        private ConsoleColor color2;

        private string CountryName;
    }
}
