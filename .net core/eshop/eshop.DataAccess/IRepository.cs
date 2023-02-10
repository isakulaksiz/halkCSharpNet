using eshop.Entities;

namespace eshop.DataAccess
{
    public interface IRepository<T> where T : IEntity
    {
        IList<T> GetAll();
        T Get(int id);

        void Add(T entity);
        void Update(T entity);
        void Delete(int id);

        //void SearchByName(string name);
        bool IsExist(int id);
    }
}
