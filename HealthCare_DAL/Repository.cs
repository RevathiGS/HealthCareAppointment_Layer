using System;
using System.Linq;
using System.Linq.Expressions;
using System.Data;
using Models;
using System.Data.Entity;
using System.Collections.Generic;

namespace HealthCare_DAL
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private Entities dataContext;
        private readonly IDbSet<T> dbset;
        protected Repository(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            dbset = DataContext.Set<T>();
        }

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        protected Entities DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }
        
        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).ToList();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).SingleOrDefault<T>();
        }

        //public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        //{
        //    return dbset.IDbSet<T>().SingleOrDefault(predicate);
        //}

    }

    public interface IRepository<T> where T : class
    {
        T GetById(string Id);
        T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
    }
}
