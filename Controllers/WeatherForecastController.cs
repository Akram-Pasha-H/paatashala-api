using Microsoft.AspNetCore.Mvc;
using PaatashalaApi.Models;

namespace PaatashalaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<TblStudent> Get()
        {
            using(var context = new WebSchoolContext())
            {
                var data = context.TblStudents.ToList();
                return data;
            }
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }

        [HttpGet("DecryptPassword")]
        public async Task<string> DecryptPassword(string text)
        {
            string password = SMSDataformatter.DecryptText(text);
            return password;
        }
    }
}