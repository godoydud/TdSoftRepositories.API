using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using TdSoftRepositories.API.Domain.DTOs;
using TdSoftRepositories.API.Service.Services;

namespace TdSoftRepositories.API.Controllers
{
    [Route("repos/")]
    [ApiController]
    public class RepositoryController : Controller
    {
        private RepositoryService _repositoryService;

        public RepositoryController(RepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
        }

        /// <summary>
        /// Permite a busca por repositorios cadastrados
        /// </summary>
        /// <description>
        /// Endpoints relacionados à repositórios
        /// </description>
        /// <response code="200">busca realizada com sucesso</response>
        /// <response code="400">ocorreu um erro na busca</response>
        [HttpGet("find")]
        public ResponseDTO<List<repositoriesDTO>> GetPaginatedRepos(
            [Required(ErrorMessage = "Nome é obrigatório")][FromQuery] string nome,
            [FromQuery] int por_pagina = 10,
            [FromQuery] int pagina = 1)
        {
            return _repositoryService.GetAllRepos(nome, pagina, por_pagina);
        }

        /// <summary>
        /// obtém dados de um repositório específico
        /// </summary>
        /// <response code="200">repositório encontrado com sucesso</response>
        [HttpGet("{repoId}")]
        public ResponseDTO<repositoriesResponseDTO> GetReposById(string repoId)
        {
            return _repositoryService.GetRepositoryById(repoId);
        }
    }
}
