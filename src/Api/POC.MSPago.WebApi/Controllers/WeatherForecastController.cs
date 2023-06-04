using Microsoft.AspNetCore.Mvc;
using POC.MSPago.Application.Features.Payments.Config;

namespace POC.MSPago.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IHostEnvironment hostEnvironment;
    private readonly MicroserviceProperties properties;


    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,
                                    IHostEnvironment hostEnvironment,
                                    MicroserviceProperties properties)
    {
        _logger = logger;
        this.hostEnvironment = hostEnvironment;
        this.properties = properties;

    }

    [HttpGet(Name = "Get")]
    public MicroserviceProperties Get()
    {
        return this.properties;
        //return $"Development: {hostEnvironment.IsDevelopment()} - Production: {hostEnvironment.IsProduction()}" ;
    }


}
