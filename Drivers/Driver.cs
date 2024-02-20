
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rainfall_API_Official.Drivers
{
    internal class Driver
    {
        public static void Main()
        {
            Driver.Navigate().GoToUrl("https://environment.data.gov.uk/flood-monitoring/id/stations?parameter=rainfall&_limit=50");

        }
       
    }
}
