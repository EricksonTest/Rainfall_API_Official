
using RainfallAPITesting.Drivers;


namespace RainfallAPITesting.StepDefinitions

{
    [Binding]

    public class SpecificDateSteps

    {
        private APIDriver apiDriver;
        private Table responseTable;

        public SpecificDateSteps(APIDriver apiDriver)

        {
            this.apiDriver = apiDriver;

        }
        [Given(@"a specific date ""(.*)""")]

        public static void GivenASpecificDate(string date);

        [When(@"I request rainfall measurements for that date")]

        public static void WhenIRequestRainfallMeasurementsForThatDate();


        [Then(@"the response should contain rainfall measurements only for that date")]

        public static void ThenTheResponseShouldContainRainfallMeasurementsOnlyForThatDate();
    }
}

