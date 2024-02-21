using NUnit.Framework;
using RainfallAPITesting.Drivers;
using RestSharp;

namespace RainfallAPITesting.StepDefinitions
{

    [Binding]
    public class LimitParameterSteps
    {
        private APIDriver apiDriver;
        private Table responseTable;

        public LimitParameterSteps (APIDriver apiDriver)

        {
            this.apiDriver = apiDriver;
        }

        [When(@"I request rainfall measurements with limit ""()""")]
        public void WhenIRequestRainfallMeasurementsWithLimit(int limit)


        {
            responseTable = apiDriver.GetRainfallMeasurements(limit);

        [Then(@"the response should contain at most (.*) rainfall measurements")]
        public void ThenTheResponseShouldContainAtMostRainfallMeasurements(int expectedCount)
        {
            Assert.LessOrEqual(responseTable.RowCount, expectedCount);
        }
    }
}