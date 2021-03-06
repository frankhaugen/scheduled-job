﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Frank.Scheduler.Api.Controllers
{
    [ApiController]
    [Route("health")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetHealth()
        {
            return Ok();
        }
    }
}
