using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SPRINT4NET.Application;
using SPRINT4NET.Application.Services;
using SPRINT4NET.Domain.DTOs;
using SPRINT4NET.Application.Interfaces;


namespace SPRINT4NET.API.Controllers;

[ApiController]
[Route("api/virus-total")]
public class URLAnaliseController : ControllerBase
{
    private readonly IURLAnaliseService _urlAnaliseService;

    public URLAnaliseController(IURLAnaliseService urlAnaliseService)
    {
        _urlAnaliseService = urlAnaliseService;
    }

    [HttpPost("analyze-url")]
    public async Task<IActionResult> AnalyzeUrl([FromBody] URLAnaliseDTO request)
    {
        var result = await _urlAnaliseService.AnalyzeUrl(request);
        return Ok(result);
    }
}
