using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using QueyHES.Models;

namespace QueyHES.Service
{
    public class HealthMinistryService
    {
        private readonly HttpClient _httpClient;
        private readonly string _hesCheckUrl = "https://api.saglikbakanligi.gov.tr/HES/dogrula";

        public HealthMinistryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<HesCodeCheckResponse>> CheckHesCodesAsync(List<HesCodeCheckRequest> hesCodes)
        {
            var content = new StringContent(JsonSerializer.Serialize(hesCodes), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(_hesCheckUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<HesCodeCheckResponse>>(responseContent);
            }

            return new List<HesCodeCheckResponse>();
        }
    }
}