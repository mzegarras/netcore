using System;
namespace POC.MSPago.Application.Features.Payments.Config;

public class AlignetProperties
{
    //public string Url { get; set; }
    public string Channel { get; set; }
    //public string Security_Code { get; set; }
    //public string Authorization { get; set; }
    public string Currency { get; set; }
    public string Description { get; set; }
    public string Reserved1 { get; set; }
    public string Reserved2 { get; set; }
    public string Reserved3 { get; set; }
    public string Country_code { get; set; }
    public string Country { get; set; }
    public string Identity_Document_Country { get; set; }
}