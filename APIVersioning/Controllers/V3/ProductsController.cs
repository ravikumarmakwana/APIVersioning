using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace APIVersioning.Controllers.V3
{
    [ApiController]
    [Route("api/v{version:apiVersion}/products")]
    [Route("api/products")]
    [ApiVersion("3.0")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetV1() => Ok("This is Products V3");
    }
}
