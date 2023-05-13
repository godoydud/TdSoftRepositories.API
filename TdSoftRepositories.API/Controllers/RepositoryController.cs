using Microsoft.AspNetCore.Mvc;

namespace TdSoftRepositories.API.Controllers
{
    [Route("repos/")]
    [ApiController]
    public class RepositoryController : Controller
    {
        [HttpGet("find")]
        public IActionResult GetAllRepos(string nome, int pagina, int por_pagina)
        {
            return Ok("Hello World");
        }

        [HttpGet("{repoId}")]
        public IActionResult GetReposById(string repoId)
        {
            return Ok("Hello World");
        }
    }
}
