using Microsoft.AspNetCore.Mvc;
using CurrencyConverterAPI.Models;

namespace CurrencyConverterAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyConverterController : ControllerBase
    {
        private const decimal ConversionInrToUsd = 0.012M; // Example conversion rate from INR to USD
        private const decimal ConversionUsdToInr = 83M;
        [HttpPost("convertInrToUsd")]
        public IActionResult ConvertInrtoUsd([FromBody] CurrencyConversionRequest request)
        {
            Console.WriteLine(request.Amount);
            var convertedAmount = request.Amount * ConversionInrToUsd;
            Console.WriteLine(convertedAmount);
            return Ok(new { ConvertedAmount = convertedAmount });
        }

        [HttpPost("convertUsdToInr")]

        public IActionResult ConvertUsdToInr([FromBody] CurrencyConversionRequest request) {
            var convertedAmount = request.Amount * ConversionUsdToInr;
            Console.WriteLine(convertedAmount);
            return Ok(new { ConvertedAmount = convertedAmount});
        }


    }
}
