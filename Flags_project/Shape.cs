using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flags
{
    using System.Threading;
    abstract class Shape
    {
        public abstract void Draw();

        public int X { get; set; }

        public int Y { get; set; }

        protected Shape(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
