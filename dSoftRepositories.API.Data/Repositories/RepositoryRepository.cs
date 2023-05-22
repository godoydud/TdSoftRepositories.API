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

        public IQueryable<repositories> GetAll() =>
            CoreContext.Set<repositories>().AsQueryable();

        public repositories GetById(string id) =>
            CoreContext.Set<repositories>().Where(x => x.id == id).FirstOrDefault();
    }
}
