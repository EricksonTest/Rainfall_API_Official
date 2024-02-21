using RestSharp;

namespace RainfallAPITesting.Drivers
{
    public class APIDriver
    {
        private RestClient client;
        public APIDriver(string baseUrl)
        {
            client = new RestClient(baseUrl);
        }
        public RestResponse GetRainfallMeasurements(string stationID, int limit)
        {
            var request = new RestRequest($"measurements?parameter=rainfall&_limit={limit}",Method.GET);

request.AddParameter("station_id", stationID);
            IRestResponse response = client.Execute(request);

            return (RestResponse)response;


        }
    }
}