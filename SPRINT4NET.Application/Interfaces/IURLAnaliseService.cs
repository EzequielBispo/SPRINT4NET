using SPRINT4NET.Domain.DTOs;
using System.Net.Http;
using System.Text.Json;
using System.Text;

namespace SPRINT4NET.Application.Interfaces
{
    public interface IURLAnaliseService
    {
        Task<string> AnalyzeUrl(URLAnaliseDTO urlAnaliseDTO);
    }
}