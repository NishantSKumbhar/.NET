using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exception
{
    internal class YouTubeException : System.Exception
    {
        public YouTubeException(string message, System.Exception innerException) : base(message, innerException)
        {

        }
    }
}
