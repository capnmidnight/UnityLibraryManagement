using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace ChuckNorris
{
    public struct Joke
    {
        public string icon_url;
        public string id;
        public string url;
        public string value;
    }

    public class ChuckNorris
    {
        private readonly RestClient client = new RestClient("https://api.chucknorris.io/jokes");

        public ChuckNorris()
        {
            client.UseNewtonsoftJson();
            client.ThrowOnAnyError = true;
        }

        public Joke GetRandom()
        {
            var request = new RestRequest("random", DataFormat.Json);
            var response = client.Get<Joke>(request);
            if(response.ResponseStatus == ResponseStatus.Completed)
            {
                return response.Data;
            }
            else
            {
                throw new System.Net.WebException($"ERR[{response.StatusCode}] = {response.ErrorMessage}");
            }
        }
    }
}
