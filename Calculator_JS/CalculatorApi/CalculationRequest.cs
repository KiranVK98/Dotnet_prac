using Microsoft.Net.Http.Headers;

public class CalculationRequest
{
    public double value1 {get;set;}
    public double value2 {get;set;}

    public string operators {get;set;} = "";
}