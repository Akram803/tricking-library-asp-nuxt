using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrickingLibrary.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "HELLO WORLD";
        }
    }
}
