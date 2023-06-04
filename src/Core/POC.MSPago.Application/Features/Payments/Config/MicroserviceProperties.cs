using System;
using Microsoft.Extensions.Configuration;

namespace POC.MSPago.Application.Features.Payments.Config;

public class MicroserviceProperties
{


    [ConfigurationKeyName("Izipay")]
    public IzipayProperties IzipayProperties { get; set; }

    [ConfigurationKeyName("Alignet")]
    public AlignetProperties AlignetProperties { get; set; }
}