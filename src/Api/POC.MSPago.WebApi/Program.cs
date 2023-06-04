using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;
using POC.MSPago.Application.Features.Payments.Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration.AddAzureAppConfiguration(options =>
                   options
                       .Connect(builder.Configuration.GetConnectionString("AppConfig"))
                        // Load configuration values with no label
                        .Select(KeyFilter.Any, LabelFilter.Null)
                            // Override with any configuration values specific to current hosting env
                            .Select(KeyFilter.Any, builder.Environment.EnvironmentName));

var microserviceProperties = new MicroserviceProperties();
builder.Configuration.GetSection("Lpsa.Payments").Bind(microserviceProperties, options => options.BindNonPublicProperties = true);

builder.Services.AddSingleton(microserviceProperties.AlignetProperties);
builder.Services.AddSingleton(microserviceProperties.IzipayProperties);
builder.Services.AddSingleton(microserviceProperties);


var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
