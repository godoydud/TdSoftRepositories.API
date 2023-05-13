using Microsoft.AspNetCore.Mvc;

namespace TdSoftRepositories.API.Controllers
{
    [Route("repos/find")]
    [ApiController]
    public class RepositoryController : Controller
    {
        [HttpGet]
        public IActionResult Get(string nome, int pagina, int por_pagina)
        {
            return Ok("Hello World");
        }
    }
}
