using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;

namespace RetailApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
    
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Bu bir deneme");
        }
    }
}
