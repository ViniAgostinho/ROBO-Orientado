using Becomex.Narwal.ROBO.Web.Models;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Becomex.Narwal.ROBO.Web.Services
{
    public class RoboService
    {
        private readonly HttpClient _httpClient;

        public RoboService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<RoboViewModel> InicializarRoboAsync()
        {
            var response = await _httpClient.PostAsync("api/Robo", null);
            response.EnsureSuccessStatusCode();
            return await ProcessResponseAsync(response);
        }

        public async Task<RoboViewModel> ObterEstadoRoboAsync()
        {
            var response = await _httpClient.GetAsync("api/Robo");
            response.EnsureSuccessStatusCode();
            return await ProcessResponseAsync(response);
        }

        public async Task<RoboViewModel> MovimentarRoboAsync(string endpoint, object dto)
        {
            var content = new StringContent(JsonSerializer.Serialize(dto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync(endpoint, content);
            return await ProcessResponseAsync(response);
        }

        private async Task<RoboViewModel> ProcessResponseAsync(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<RoboViewModel>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new ApiException
                {
                    StatusCode = (int)response.StatusCode,
                    ErrorMessage = errorContent ?? "Erro desconhecido"
                };
            }
        }
    }

    public class ApiException : Exception
    {
        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; }

        public ApiException() : base() { }
        public ApiException(string message) : base(message) { }
    }
}
