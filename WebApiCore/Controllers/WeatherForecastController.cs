using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApiCore.Controllers
{
    /// <summary>
    /// 这是一个测试的控制器
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        ///
	///  This is a test
	/// 
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// 获取项目的id
        /// </summary>
        /// <param name="id">主键参数</param>
        /// <returns></returns>
        [HttpGet]
        [Route("ProjectgetId")]
        public IActionResult ProjectgetId(int id)
        {
            return new JsonResult(new
            {
                Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                port = id,
                Version = "V1"
            });
        }
        /// <summary>
        /// 获取项目的id
        /// </summary>
        /// <param name="id">主键参数</param>
        /// <returns></returns>
        [HttpGet]
        [Route("ProjectgetIds")]
        public IActionResult ProjectgetIds(int id)
        {
            return new JsonResult(new
            {
                Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                port = id,
                Version = "V1"
            });
        }
        //[HttpGet]
        //public ActionResult<int> get(int id)
        //{
        //    return id;
        //}
        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}
