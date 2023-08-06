using System.Text.Json;

namespace safeOps.Client.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient http;

        public HttpService(HttpClient http)
        {
            this.http = http;
        }
        public async Task<HttpResponse<T>> Get<T>(string url)
        {
            var response = await http.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var respo = await DeserializeResponse<T>(response);
                return new HttpResponse<T>(respo, false, response);
            }
            else
            {

                return new HttpResponse<T>(default, true, response);

            }
        }

        private async  Task<T>DeserializeResponse<T>(HttpResponseMessage response)
        {
            var respoStr = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(respoStr,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
