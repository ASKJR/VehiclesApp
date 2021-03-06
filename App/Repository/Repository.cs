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
            Collection = Collection.Where(v => v.Id != id);
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
            Collection = Collection.Concat(new[] { entity });
        }

        public void Update(Guid id, T entity)
        {
            var v = Collection.FirstOrDefault(v => v.Id == id);
            
            if (v is not null)
            {
                v.Color = entity.Color;
            }
        }
    }
}
