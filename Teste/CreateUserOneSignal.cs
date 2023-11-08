using System.Net.Http.Headers;

namespace Teste
{
    public class CreateUserOneSignal
    {
        public async void CreateUser()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://onesignal.com/api/v1/apps/ea5f25b1-06ca-4718-b454-469436246919/users"),
                Headers =
                {
                    { "accept", "application/json" },
                },
                Content = new StringContent("{\"properties\":{\"tags\":{\"key\":\"testando\",\"foo\":\"bar\"},\"language\":\"en\",\"timezone_id\":\"America\\\\/Los_Angeles\",\"lat\":90,\"long\":135,\"country\":\"US\",\"first_active\":1678215680,\"last_active\":1678215682},\"identity\":{\"external_id\":\"test_external_id\"}}")
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }

        public async void ViewUser()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://onesignal.com/api/v1/apps/ea5f25b1-06ca-4718-b454-469436246919/users/by/alias_label/alias_id"),
                Headers =
                {
                    { "accept", "application/json" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }

        public async void CreateNotification()
        {
          //  var usuarios = "\"include_aliases\": { \"external_id\": [\"custom-external_id-assigned-by-api-1\", \"custom-external_id-assigned-by-api-2\", \"custom-external_id-assigned-by-api-3\"]}}" \";
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://onesignal.com/api/v1/notifications"),
                Headers =
                {
                    { "accept", "application/json" },
                    { "Authorization", "Basic ZjVhMzhhMDAtM2MzNC00MzQxLWI1M2YtMjk3OGJjOGRhNWY3" },
                },
                Content = new StringContent("{\"included_segments\":[\"Specific Devices\"],\"contents\":{\"pt\":\"Portuguese or Any Language Message\",\"es\":\"Spanish Message\"},\"name\":\"INTERNAL_CAMPAIGN_NAME\",\"app_id\":\"ea5f25b1-06ca-4718-b454-469436246919\"}, \"include_aliases\": { \"external_id\": [\"test_external_id\"]}}")
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }

        public async void CreateDevice()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://onesignal.com/api/v1/players"),
                Headers =
                {
                    { "accept", "application/json" },
                },
                Content = new StringContent("{\"device_type\":14,\"language\":\"en\",\"timezone\":\"-28800\",\"game_version\":\"1.1.1\",\"device_model\":\"iPhone5,1\",\"device_os\":\"15.1.1\",\"session_count\":600,\"tags\":{\"first_name\":\"Jon\",\"last_name\":\"Smith\",\"level\":\"99\",\"amount_spent\":\"6000\",\"account_type\":\"VIP\"},\"amount_spent\":\"100.99\",\"playtime\":600,\"notification_types\":1,\"lat\":37.563,\"long\":122.3255,\"country\":\"US\",\"timezone_id\":\"Europe\\\\/Warsaw\",\"external_user_id\":\"e87713c5-cd33-4a95-a11e-502f251de332\",\"app_id\":\"ea5f25b1-06ca-4718-b454-469436246919\",\"identifier\":\"5511959494772\"}")
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }
    }
}
