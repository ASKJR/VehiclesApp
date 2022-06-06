using VehiclesApp.Model.Interfaces;

namespace VehiclesApp.Repository
{
    public class Repository<T> : IRepository<T> where T : class, IVehicle
    {
        private IEnumerable<T> Collection;

        public Repository(IEnumerable<T> collection)
        {
            Collection = collection;
        }
        
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public T Get(Guid id)
        {
            return Collection.Where(v => v.Id == id).First();
        }

        public IEnumerable<T> GetAll()
        {
            return Collection;
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
