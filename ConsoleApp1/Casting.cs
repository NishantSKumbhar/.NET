using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Casting
    {

    }

    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int height { get; set; }
        public int width { get; set; }

        public void draw()
        {

        }
    }

    public class Text: Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }
}
