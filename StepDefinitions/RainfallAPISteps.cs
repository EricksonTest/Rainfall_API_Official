using NUnit.Framework;
using RainfallAPITesting.Drivers;
using RestSharp;

namespace RainfallAPITesting.StepDefinitions
{

    [Binding]
    public class RainfallAPISteps
    {
        private APIDriver apiDriver;


        [Given(@"a measurement station ID ""(.*)""")]
        public void GivenAMeasurementStationID(string StationID)
        {
            apiDriver = new APIDriver("https://environment.data.gov.uk/flood-monitoring/id/stations/");
            apiDriver.Initialize(StationID);
        }
    }
}
