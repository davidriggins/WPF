using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaUserControlDemo.Database
{
    public class MockDb
    {
        public static Uri GetPostVideo()
        {   
            // Simulate fetching a video source from a database
            return new Uri("pack://application:,,,/Videos/cat.mp4", UriKind.Absolute);
        }
    }
}
