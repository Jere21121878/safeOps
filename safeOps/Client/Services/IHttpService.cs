namespace safeOps.Client.Services
{
    public interface IHttpService
    {
        Task<HttpResponse<T>> Get<T>(string url);
    }
}