using TdSoftRepositories.API.Data.Context;
using TdSoftRepositories.API.Domain.Entities;

namespace TdSoftRepositories.API.Data.Repositories
{
    public class RepositoryRepository
    {
        public CoreContext CoreContext { get; }

        public RepositoryRepository(CoreContext context)
        {
            CoreContext = context;
        }

        public IQueryable GetAll() =>
            CoreContext.Set<Repository>().AsQueryable();

        public Repository GetById(string id) =>
            CoreContext.Set<Repository>().Find(id);
    }
}
