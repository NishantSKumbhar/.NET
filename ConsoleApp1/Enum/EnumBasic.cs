using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Enum
{
    public enum ShippingMethod
    {
        Express = 1,
        RegularAirMail = 2,
        RegisteredAirMain = 3

    }
    internal class EnumBasic
    {
        // Enum is internally integer
        public void displayEnums()
        {
            var num = ShippingMethod.Express;
            Console.WriteLine(num);
        }
    }
}
