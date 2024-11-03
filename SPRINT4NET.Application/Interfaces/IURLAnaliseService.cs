using SPRINT4NET.Domain.DTOs;

namespace SPRINT4NET.Application.Interfaces
{
    public class IURLAnaliseService
    {
        Task<string> AnalyzeUrl(URLAnaliseDTO request);

    }
}