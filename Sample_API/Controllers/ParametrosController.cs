using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sample_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParametrosController : ControllerBase
    {
        [HttpGet("Nome/{name}")]
        public string GetName([FromRoute] string name)
        {
            return $"O nome passado no parametro foi {name}";
        }

        [HttpPost]
        public Task CreatePerson([FromBody] Person person)
        {
            Console.WriteLine($"O nome da pessoa é {person.Name} e o seu sobrenome é {person.Surname}");
            return Task.CompletedTask;
        }

        [HttpGet("FromQuery")]
        public string GetQuery([FromQuery] string query)
        {
            return $"A query string foi {query}";
        }

        [HttpHead]
        public void GetHead([FromHeader]string header) 
        {
            Console.WriteLine(header);
        }
    }
    public class Person 
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }

}
