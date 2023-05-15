using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using TdSoftRepositories.API.Domain.Entities;

namespace TdSoftRepositories.API.Controllers
{
    [Route("repos/")]
    [ApiController]
    public class RepositoryController : Controller
    {
        /// <summary>
        /// Permite a busca por repositorios cadastrados
        /// </summary>
        /// <description>
        /// Endpoints relacionados à repositórios
        /// </description>
        /// <response code="200">busca realizada com sucesso</response>
        /// <response code="400">ocorreu um erro na busca</response>
        [HttpGet("find")]
        public List<Repository> GetAllRepos([Required(ErrorMessage = "Nome é obrigatório")]string nome, int pagina, int por_pagina)
        {
            return new List<Repository>();
        }

        /// <summary>
        /// obtém dados de um repositório específico
        /// </summary>
        /// <response code="200">repositório encontrado com sucesso</response>
        [HttpGet("{repoId}")]
        public Repository GetReposById(string repoId)
        {
            return new Repository { Id = repoId };
        }
    }
}
