using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConsulDemo.Models;

namespace ConsulDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/Health")]
    public class HealthController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            Console.WriteLine("健康检查" + DateTime.Now);
            return Content("ok");
        }
    }
}
