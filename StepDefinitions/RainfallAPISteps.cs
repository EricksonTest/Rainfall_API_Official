using NUnit.Framework;
using RainfallAPITesting.Drivers;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace RainfallAPITesting.StepDefinitions
{

    [Binding]
    public class RainfallAPISteps

    private APIDriver apiDriver;
    private Table responseTable;

    public RainfallAPISteps(APIDriver apiDriver)
    {
        this.apiDriver = apiDriver;
    }
}

[Given(@"a measurement station ID ""(.*)""")]
public void GivenAMeasurementStationID(string StationID)

{
    APIDriver.Initialize(StationID);
}

[When(@"I request rainfall measurements with limit ""(.*)""")]

public void WhenIRequestRainfallMeasurementsWithLimit (int limit)

{
    responseTable = APIDriver.GetRainfallMeasurements(limit);
}

[Then(@"the response should contain at most (.*) rainfall measurements")]
public void ThenTheResponseShouldContainAtMostRainfallMeasurements (int expectedCount)
{
    Assert.LessOrEqual(responseTable.RowCount, expectedCount);
}
}
