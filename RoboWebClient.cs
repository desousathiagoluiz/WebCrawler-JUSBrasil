using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SeuNamespace
{
    public class RoboWebClient
    {
        private readonly HttpClient _httpClient;

        public RoboWebClient()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36");
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar HTML: {ex.Message}");
            }
        }

        // se você precisar fazer um POST ou outras operações, você pode adicionar mais métodos aqui.
    }
}