using hometask_webappi_intro.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hometask_webappi_intro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public List<Product> list = new()
        {
            new(){Name="Product1",Description="bbbbbbbbbbbbbbb"},
            new(){Name="Product2",Description="bbbbbbbbbbbbbbb"},
            new(){Name="Product3",Description="bbbbbbbbbbbbbbb"},
            new(){Name="Product4",Description="bbbbbbbbbbbbbbb"}
        };
        [HttpGet]
        public IActionResult Get()
        {
            return StatusCode(200, list);
        }
    }
}
