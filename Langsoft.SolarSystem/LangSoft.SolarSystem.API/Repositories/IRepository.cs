using System.Collections.Generic;

namespace LangSoft.SolarSystem.API.Repositories
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> Get();
        T Get(object id);
        void Add(T entity);
        void Remove(T entity);
    }
}
