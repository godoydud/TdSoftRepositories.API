using TdSoftRepositories.API.Data.Context;
using TdSoftRepositories.API.Domain.Entities;

namespace TdSoftRepositories.API.Data.Repositories
{
    public class ActorsRepository
    {
        public CoreContext CoreContext { get; }

        public ActorsRepository(CoreContext context)
        {
            CoreContext = context;
        }

        public actors GetById(string id) =>
            CoreContext.Set<actors>().Where(x => x.id == id).FirstOrDefault();

        public IQueryable<actors> GetAll() =>
            CoreContext.Set<actors>().AsQueryable();
    }
}
