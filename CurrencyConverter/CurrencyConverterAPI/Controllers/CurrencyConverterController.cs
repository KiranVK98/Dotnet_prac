using Microsoft.AspNetCore.Mvc;
using CurrencyConverterAPI.Models;
using System.Security.Cryptography.X509Certificates;

namespace CurrencyConverterAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyConverterController : ControllerBase
    {
        private const decimal UsdToInr = 83.50M;
        private const decimal InrToUsd = 0.012M;

        [HttpPost("convertUsdToInr")]
        public IActionResult convertUsdToInr([FromBody] CurrencyConversionRequest convertUsdToInr)
        {
            decimal Result = convertUsdToInr.Amount * UsdToInr;       
            return Ok(new {ConvertedAmount = Result});


        }

        [HttpPost("convertInrToUsd")]

        public IActionResult convertInrToUsd([FromBody] CurrencyConversionRequest convertInrToUsd)
        {
            decimal Result = convertInrToUsd.Amount * InrToUsd;

            return Ok(new {ConvertedAmount = Result});
        }



    }
}
