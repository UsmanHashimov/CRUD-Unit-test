namespace Crud_Unit_Test.Repositories.Base
{
    public interface IGenericRepository<T>
    {
        public ValueTask<T> AddAsync(T model);
        public ValueTask<T> GetAsync(int id);
        public ValueTask<List<T>> GetAllAsync();
        public ValueTask<T> UpdateAsync(T model);
        public ValueTask<T> DeleteAsync(T model);
    }
}
