using ObjectLibrary.Abstractions;
using RepositoryPatternLibrary.Abstractions;

namespace RepositoryPatternLibrary.Repositories.User
{
    public interface IUserRepository : IRepository<IUser, int>
    {
        IUser GetByUsername(string username);
    }
}
