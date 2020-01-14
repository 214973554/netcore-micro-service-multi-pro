using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientService.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("api/values")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "ClinetService-value1", "ClinetService-value2" };
        }

        [Route("api/health")]
        [HttpGet]
        public IActionResult Healthy()
        {
            return Ok("ok");
        }
    }
}