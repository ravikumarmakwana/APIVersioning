using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace APIVersioning.Controllers.V1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/products")]
    [Route("api/products")]
    [ApiVersion("1.0")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetV1() => Ok("This is Products V1");
    }
}