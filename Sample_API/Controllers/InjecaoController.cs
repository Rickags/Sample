using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample_API.Services;

namespace Sample_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InjecaoController(IExempleService exampleService) : ControllerBase
    {
        private readonly IExempleService exampleService = exampleService;

        [HttpGet("1")]
        public ActionResult Endpoint01()
        {
            ExempleService exs = new();
            exs.WriteExample();
            exs.WriteName("Ricardo");
            return Ok("Endpoint 01...");
        }

        [HttpGet("2")]
        public ActionResult Endpoint02()
        {
            exampleService.WriteExample();
            exampleService.WriteName("Ric");
            return Ok("Endpoint 02...");
        }

        [HttpGet("3")]
        public ActionResult Endpoint03([FromServices] IExempleService exs)
        {
            exampleService.WriteExample();
            exampleService.WriteName("");
            return Ok("Endpoint 03...");
        }
    }
}
