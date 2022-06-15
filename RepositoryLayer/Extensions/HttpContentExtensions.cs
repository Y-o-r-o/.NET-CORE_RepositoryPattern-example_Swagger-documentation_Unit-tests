using System.Text.Json;

namespace RepositoryLayer.Extensions
{
    public static class HttpContentExtensions
    {
        public async static Task<T> Read<T>(this HttpContent content)
        {
            var contentStream = await content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<T>(contentStream);
        }
    }
}