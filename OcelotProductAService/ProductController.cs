using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OcelotProductAService
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        public IConfiguration Configuration { get; }

        public ProductController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return HttpContext.Request.Host.Port + " " + Configuration["AppName"] + "A " + DateTime.Now.ToString();
        }

        [HttpGet("/health")]
        public IActionResult Heathle()
        {
            return Ok();
        }
    }
}
