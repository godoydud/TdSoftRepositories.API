using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.Data.Entity;
using TdSoftRepositories.API.Data.Repositories;
using TdSoftRepositories.API.Domain.DTOs;
using TdSoftRepositories.API.Domain.Entities;

namespace TdSoftRepositories.API.Service.Services
{
    public class RepositoryService
    {
        private readonly RepositoryRepository _repositoryRepository;
        private readonly ActorsRepository _actorsRepository;
        private readonly IMapper _mapper;

        public RepositoryService(RepositoryRepository repositoryRepository, ActorsRepository actorsRepository, IMapper mapper)
        {
            _repositoryRepository = repositoryRepository;
            _actorsRepository = actorsRepository;
            _mapper = mapper;
        }

        #region [Get All Repositories Paginated]
        public ResponseDTO<List<repositoriesDTO>> GetAllRepos(string nome, int pagina, int por_pagina)
        {
            try
            {
                if(nome == null)
                    return new ResponseDTO<List<repositoriesDTO>>(StatusCodes.Status400BadRequest, "Nome é obrigatório");
                    
                IQueryable<repositories> repos = _repositoryRepository.GetAll().Where(x => x.name.Contains(nome));

                if (repos.Count() == 0)
                    return new ResponseDTO<List<repositoriesDTO>>(StatusCodes.Status404NotFound, "Repositório não encontrado");

                if (pagina > 0 && por_pagina > 0)
                    repos = repos.Skip((pagina - 1) * por_pagina).Take(por_pagina);

                var result = repos.Select(x => new repositoriesDTO
                {
                    id = x.id,
                    name = x.name
                }).ToList();

                return new ResponseDTO<List<repositoriesDTO>>(StatusCodes.Status200OK, result, "busca realizada com sucesso");

            } catch (Exception ex)
            {
                return new ResponseDTO<List<repositoriesDTO>>(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        #endregion

        #region [Get Repository By Id]
        public ResponseDTO<repositoriesResponseDTO> GetRepositoryById(string id)
        {
            try
            {
                var repo = _repositoryRepository.GetAll().Where(x => x.id.Equals(id)).FirstOrDefault();
                if (repo == null)
                    return new ResponseDTO<repositoriesResponseDTO>(StatusCodes.Status404NotFound, "Repositório não encontrado");

                var repoDTO = _mapper.Map<repositoriesResponseDTO>(repo);

                var ownerRepo = _actorsRepository.GetAll().Where(x => x.id.Equals(repo.owner)).FirstOrDefault();
                if (ownerRepo == null)
                    return new ResponseDTO<repositoriesResponseDTO>(StatusCodes.Status404NotFound, "Owner de repositório não encontrado");

                repoDTO.repos_owner = new actorsDTO { id = ownerRepo.id, avatar_url = ownerRepo.avatar_url, login = ownerRepo.login, type = ownerRepo.type };

                return new ResponseDTO<repositoriesResponseDTO>(StatusCodes.Status200OK, repoDTO, "repositório encontrado com sucesso");
            }
            catch (Exception ex)
            {
                return new ResponseDTO<repositoriesResponseDTO>(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        #endregion
    }
}
