using Crud_Unit_Test.Data;
using Crud_Unit_Test.Models;
using Crud_Unit_Test.Repositories.Base;

namespace Crud_Unit_Test.Repositories.Users
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context) { }
    }
}
