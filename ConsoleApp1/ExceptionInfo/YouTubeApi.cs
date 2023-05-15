using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exception
{
    internal class YouTubeApi
    {
        public List<int> GetVideos(string user)
        {
			try
			{
				throw new System.Exception("oops, something happen with youtube");
			}
			catch (System.Exception ex)
			{

				throw new YouTubeException("Could not fetch the files from Youtube.", ex);
			}

			return new List<int>();
        }
    }
}
