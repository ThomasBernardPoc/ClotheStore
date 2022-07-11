using System.Net.Http.Headers;

namespace ClotheStore.Services.Interfaces;

public interface IHttpService
{
    public Task<T> SendHttpRequest<T>(string url, HttpMethod httpMethod, HttpRequestHeaders headers = null);
}
