Feature: Limit Rainfall measurement results

Scenario Outline: Theres a new functionality added to the rainfall API website and we need to test the functionality to ensure that it works as intended and that we are able to hit the end point API The new functionality has been added in a way that we can limit the amount of measurement that we want from the parameter.



Scenario: Limit Measurement
Given A measurement station ID "station_id"
And I request rainfall measurements with limit "5"
Then the response should contain at most 5 rainfall measurements

Scenario: Specific Date Measurement
Given a measurement station ID "station_id"
Given a specific date "2024-02-20"
When I request rainfall measurements for that date
Then the response should contain rainfall measurements only for that date