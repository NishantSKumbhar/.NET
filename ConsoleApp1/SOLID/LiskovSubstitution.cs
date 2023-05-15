using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SOLID
{
    internal class LiskovSubstitution
    {

        public int price;
        public string name;
        public string description;

        public LiskovSubstitution(int price, string name, string description)
        {
            this.price = price;
            this.name = name;
            this.description = description;
        }

        public double getPrice()
        {
            return this.price;
        }
    }


    class l1 : LiskovSubstitution
    {
        public l1(int price, string name, string description) : base(price, name, description)
        {

        }

        public double getPriceWithDiscount(int discountPercent)
        {
            return this.price - (discountPercent * 0.01 * this.price);
        }
    }
}
