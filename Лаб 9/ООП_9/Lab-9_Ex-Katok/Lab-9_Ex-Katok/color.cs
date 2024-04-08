using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_9_Ex_Katok
{
    public class color
    {
        public int R { get; }
        public int G { get; }
        public int B { get; }
        public color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }
        public static int operator-(color c1, color c2)
        {
            return (c1.R + c1.G + c1.B) - (c2.R + c2.G + c2.B);
        }
        public Color getColor()
        {
            return Color.FromArgb(R, G, B);
        }
    }
}
