using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.OpenApi.Services;
using System;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();


var app = builder.Build();

// Allow any CORS for development purposes (replace with specific origins in production)
app.UseCors(options =>
options.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader()
);
// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    // Disable HTTPS redirection for development to avoid certificate errors
    app.UseHttpsRedirection(); // Call without arguments to disable
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseDefaultFiles();
app.UseStaticFiles();


app.Run();


namespace ControllerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CalculatorController : ControllerBase
    {
        private readonly Dictionary<string, Calculate> dict;

        public CalculatorController()
        {
            dict = new Dictionary<string, Calculate>{
                {"+", new Addition()},
                 {"-", new Subtraction()},
                  {"*", new Multiply()},
                   {"/", new Divide()}

            };
        }

        [HttpPost("execute")]
        public IActionResult Execute([FromBody] CalculationRequest request) 
        {
            if(request == null)
            {
                return new BadRequestObjectResult("Invalid request");
            }

            if(!dict.ContainsKey(request.operators))
            {
                return new BadRequestObjectResult("Inavlid Operation");
            }

            try 
            {
                double result = dict[request.operators].Calculate_op(request.value1,request.value2);
                return new OkObjectResult(result);
            }
            catch(Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }
    }
}
