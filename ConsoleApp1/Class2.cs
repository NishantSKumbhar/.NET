using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        // Eager loading
        //private static Class2 objC2 = new Class2();

        //private Class2()
        //{

        //}
        //public static Class2 getInstance() { return objC2; }


        // Lazyloading
        private static Class2 objC2 = null;

        private Class2()
        {

        }
        public static Class2 getInstance() 
        { 
        
            if(objC2 == null)
            {
                objC2 = new Class2();
            }
            return objC2;

        }

    }
}
