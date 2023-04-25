using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Recursion
{
    internal class Recursion_2
    {
        // ways of traversing matrix from start to end : Condition only right and bottom
        public int waysInMNMatrixRec(int m, int n)
        {
            if(m == 1 || n == 1) return 1;
            int ans = waysInMNMatrixRec(m-1, n) + waysInMNMatrixRec(m, n-1);
            return ans;

        }
    }
}
