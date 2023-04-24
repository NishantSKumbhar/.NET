using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Math
{
    public class Circle
    {
        public int radius;
        public const float PI = 3.14f;
        public float getAreaOfCircle()
        {
            return PI * (this.radius * this.radius);
        }
    }

}
