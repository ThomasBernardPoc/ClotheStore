using ClotheStore.Services.Interfaces;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ClotheStore.Services;

internal class HttpService : IHttpService
{
    private readonly HttpClient _httpClient;
    public HttpService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<T> SendHttpRequest<T>(string url, HttpMethod httpMethod, HttpRequestHeaders headers = null)
    {
        try
        {
            var request = new HttpRequestMessage
            {
                Method = httpMethod,
                RequestUri = new Uri(url),
                Headers =
            {
                { "X-RapidAPI-Key", "dc28aefa49msh46ea4b9e4afdffep107050jsna6e09df14814" },
                { "X-RapidAPI-Host", "asos2.p.rapidapi.com" },
            },
            };
            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(body);
            return result;
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
            return default(T);
        }
    }
}
