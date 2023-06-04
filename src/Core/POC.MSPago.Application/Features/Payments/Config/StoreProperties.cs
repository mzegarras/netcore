using System;
using Microsoft.Extensions.Configuration;

namespace POC.MSPago.Application.Features.Payments.Config;

public class StoreProperties
{
    public string Url { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Currency { get; set; }
}

public class IzipayProperties
{
    [ConfigurationKeyName("Stores")]
    public Dictionary<string, StoreProperties> Stores { get; set; }

    /*public IzipayProperties() {
        this.Stores = new Dictionary<string, StoreProperties>();
    }*/
}