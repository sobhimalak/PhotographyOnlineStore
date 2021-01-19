﻿using System.Data.Entity;
using System.Linq;
using PhotographyOnlineStore.Core.Contracts;
using PhotographyOnlineStore.Core.Models;

namespace PhotographyOnlineStore.DataAccess.SQL
{
    public class SqlRepositoryData<T> : IRepository<T> where T : BaseEntity
    {
        internal DataContext db;
        internal DbSet<T> dbSet;

        //       private readonly DataContext db;
        //       string className;

        public SqlRepositoryData(DataContext db)
        {
            this.db = db;
            this.dbSet = db.Set<T>();
        }

        public IQueryable<T> Collection()
        {
            return dbSet;
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete(string Id)
        {
            var t = Find(Id);

            if (db.Entry(t).State == EntityState.Detached)
                dbSet.Attach(t);
            dbSet.Remove(t);
        }

        public T Find(string Id)
        {
            return dbSet.Find(Id);
        }

        public void Insert(T t)
        {
            dbSet.Add(t);
        }

        public void Update(T t)
        {
            dbSet.Attach(t);
            db.Entry(t).State = EntityState.Modified;
        }
    }
}
