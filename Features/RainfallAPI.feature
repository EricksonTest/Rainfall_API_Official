Feature: Limit Rainfall measurement results

Scenario Outline: Theres a new functionality added to the rainfall API website and we need to test the functionality to ensure that it works as intended and that we are able to hit the end point API The new functionality has been added in a way that we can limit the amount of measurement that we want from the parameter.


@Limitparameter
Scenario: Limit Measurement
Given I open the chrome browser
Then I navigate to the desired Rainfall URL 'https://environment.data.gov.uk/flood-monitoring/id/stations?parameter=rainfall&_limit=10'
When I fetch data of a particular station
Then Limit the amount of measurements to just 10