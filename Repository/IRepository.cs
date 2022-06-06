namespace VehiclesApp.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Guid id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}
