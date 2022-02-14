using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Ex4_2
{
    internal class Circle
    {
        public double radius { get; set; }

        public double CalArea()
        {
            return Math.Round(radius * radius * 3.14,2);
        }

        public double CalCircumference()
        {
            return Math.Round(radius * 2 * 3.14,2);
        }
    }
}
