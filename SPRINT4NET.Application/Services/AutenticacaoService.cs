using SPRINT4NET.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SPRINT4NET.Application.Interfaces;

namespace SPRINT4NET.Application.Services
{
    public class AutenticacaoService : IAutenticacaoService
    {
        private readonly HttpClient _httpClient;

        public AutenticacaoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> AuthenticateUser(CredencialEntity credentials)
        {
            var jsonContent = JsonSerializer.Serialize(credentials);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("http://127.0.0.1:5000", content);

            return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
        }
    }
}
