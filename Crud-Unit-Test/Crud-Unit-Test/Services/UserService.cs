using Crud_Unit_Test.Models;
using Crud_Unit_Test.Repositories.Users;

namespace Crud_Unit_Test.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
            => _repository = repository;

        public async ValueTask<User> AddAsync(User product)
        {
            return await _repository.AddAsync(product);
        }

        public async ValueTask<User> DeleteAsync(int id)
        {
            var storedProduct = await _repository.GetAsync(id);

            if (storedProduct == null)
                throw new Exception("");

            return await _repository.DeleteAsync(storedProduct);
        }

        public async ValueTask<List<User>> GetAllAsync()
            => await _repository.GetAllAsync();

        public async ValueTask<User> GetAsync(int id)
        {
            var storedProduct = await _repository.GetAsync(id);

            if (storedProduct == null)
                throw new Exception("");

            return storedProduct;
        }

        public async ValueTask<User> UpdateAsync(User product, int id)
        {
            var storedProduct = await _repository.GetAsync(id);

            if (storedProduct == null)
                throw new Exception("");

            return await _repository.UpdateAsync(storedProduct);
        }
    }
}
