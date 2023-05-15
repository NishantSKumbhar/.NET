using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exception
{
    internal class ExceptionMainStart
    {

        public static void start()
        {
			try
			{
				var api = new YouTubeApi();
				var videos = api.GetVideos("ForkInfoSystem");
			}
			catch (System.Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
        }
    }
}
