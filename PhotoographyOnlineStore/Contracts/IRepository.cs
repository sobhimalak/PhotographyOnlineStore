using PhotoographyOnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoographyOnlineStore.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void commit();
        void Delete(string Id);
        T Find(string Id);
        void insert(T t);
        void Update(T t);
    }
}