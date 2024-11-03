using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using SPRINT4NET.Domain.Entities;
using SPRINT4NET.Application.Interfaces;

namespace SPRINT4NET.Application.Services
{
    public class URlAnaliseService : IURLAnaliseService
    {
        private readonly HttpClient _httpClient;

        public URlAnaliseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> AnalyzeUrl(URLAnalise request)
        {
            _httpClient.DefaultRequestHeaders.Add("x-apikey", "33ac1b2cfed770fde460035a01296c246116b5b17888f8ce97050d3c1b7be022");
            var jsonContent = JsonSerializer.Serialize(new { url = request.Url });
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://www.virustotal.com/api/v3/urls", content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
