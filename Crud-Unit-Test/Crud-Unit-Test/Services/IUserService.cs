using Crud_Unit_Test.Models;

namespace Crud_Unit_Test.Services
{
    public interface IUserService
    {
        public ValueTask<User> AddAsync(User User);
        public ValueTask<User> GetAsync(int id);
        public ValueTask<List<User>> GetAllAsync();
        public ValueTask<User> UpdateAsync(User User, int id);
        public ValueTask<User> DeleteAsync(int id);
    }
}
