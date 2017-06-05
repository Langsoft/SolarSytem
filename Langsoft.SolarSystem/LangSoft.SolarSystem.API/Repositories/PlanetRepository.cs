using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using LangSoft.SolarSystem.API.Models;
using System.Data.Entity;

namespace LangSoft.SolarSystem.API.Repositories
{
    public class PlanetRepository<T> : IRepository<T> where T : class
    {
        private SolarSystemEntities db = null;
        private DbSet<T> table = null;

        public PlanetRepository()
        {
            this.db = new SolarSystemEntities();
            this.table = db.Set<T>();
        }

        public PlanetRepository(SolarSystemEntities db)
        {
            this.db = db;
            this.table = db.Set<T>();
        }

        // not implemented only retrieving
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get()
        {
            return table.ToList();
        }

        public T Get(object id)
        {
            return table.Find(id);
        }

        // not implemented only retrieving
        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}