using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sample_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PessoaController(IConfiguration configuration) : ControllerBase
    {
        private readonly IConfiguration _configuration = configuration;

        [HttpGet("Get-String-Conexao")]
        public string GetString()
        {
            return _configuration["ConnectionStrings:DefaultConnection"]!;
        }

        
    }
}
