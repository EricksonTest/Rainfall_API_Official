using RestSharp;

namespace RainfallAPITesting.Drivers
{
    public class APIDriver
    {
        private RestClient client;

        public RestResponse response { get; private set; }

        public APIDriver(string baseUrl)
        {
            client = new RestClient(baseUrl);
        }
        public void Initialize(string stationID);
        public IRestResponse GetRainfallMeasurements( int limit)
        {
            var request = new RestRequest($"measurements?parameter=rainfall&_limit={limit}",Method.GET);

            return response;


        }
    }
}