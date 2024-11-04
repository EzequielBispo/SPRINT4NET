using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using SPRINT4NET.Domain.Entities;
using SPRINT4NET.Application.Interfaces;
using SPRINT4NET.Domain.DTOs;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace SPRINT4NET.Application.Services
{
    public class URlAnaliseService : IURLAnaliseService
    {
        private readonly HttpClient _httpClient;

        public URlAnaliseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> AnalyzeUrl(URLAnaliseDTO request)
        {
            _httpClient.DefaultRequestHeaders.Add("x-apikey", "33ac1b2cfed770fde460035a01296c246116b5b17888f8ce97050d3c1b7be022");
            var urlToAnalyze = Convert.ToBase64String(Encoding.UTF8.GetBytes(request.Url)).TrimEnd('=');

            var urlToAnalyzeEncoding = Uri.EscapeDataString(request.Url);

            var content = new StringContent($"{{\"url\":\"{urlToAnalyzeEncoding}\"}}", Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"https://www.virustotal.com/api/v3/urls?url={urlToAnalyzeEncoding}", content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
