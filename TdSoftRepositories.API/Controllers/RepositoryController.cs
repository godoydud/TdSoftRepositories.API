using Microsoft.AspNetCore.Mvc;
using TdSoftRepositories.API.Domain.Entities;

namespace TdSoftRepositories.API.Controllers
{
    [Route("repos/")]
    [ApiController]
    public class RepositoryController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="pagina"></param>
        /// <param name="por_pagina"></param>
        /// <returns>Todos repositórios</returns>
        /// <response code="200">Retorna todos os repositórios</response>
        [HttpGet("find")]
        public List<Repository> GetAllRepos(string nome, int pagina, int por_pagina)
        {
            return new List<Repository>();
        }

        [HttpGet("{repoId}")]
        public Repository GetReposById(string repoId)
        {
            return new Repository { Id = repoId };
        }
    }
}
