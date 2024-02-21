using NUnit.Framework;
using RainfallAPITesting.Drivers;
using RestSharp;

namespace RainfallAPITesting.StepDefinitions
{

    [Binding]
    public class RainfallAPISteps
    {
        private APIDriver apiDriver;
        private IRestResponse response;


        [Given(@"a measurement station ID ""(.*)""")]
        public void GivenAMeasurementStationID(string StationID)
        {
            apiDriver = new APIDriver("https://environment.data.gov.uk/flood-monitoring/id/stations/");
        }

        [When(@"I request rainfall measurements with limit ""(.*)""")]
        public void WhenIRequestRainfallMeasurementsWithLimit(string limit)

        {
            response = apiDriver.GetRainfallMeasurements("your_station_id_here", int.Parse(limit));
        }

        [Then(@"the response should contain at most (.*) rainfall measurements")]
        public void ThenTheResponseShouldContainAtMostRainfallMeasurements(int expectedCount)
        {
            var measurements = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content);
            Assert.LessOrEqual(measurements.items.Count, expectedCount);
        }
    }
}
