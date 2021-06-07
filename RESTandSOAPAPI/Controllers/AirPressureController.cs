using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RESTandSOAPAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTandSOAPAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirPressureController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<AirPressureController> _logger;

        public AirPressureController(ILogger<AirPressureController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Response Get([FromQuery] Request request)
        {
            return new Response()
            {
                Pressure = 1008.0
            };
        }
    }
}
