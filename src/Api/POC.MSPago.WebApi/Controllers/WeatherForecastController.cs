using Microsoft.AspNetCore.Mvc;

namespace POC.MSPago.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IHostEnvironment hostEnvironment;


    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IHostEnvironment hostEnvironment)
    {
        _logger = logger;
        this.hostEnvironment = hostEnvironment;

    }

    [HttpGet(Name = "Get")]
    public string Get()
    {
        return $"Development: {hostEnvironment.IsProduction()} - Production: {hostEnvironment.IsProduction()}" ;
    }
}
