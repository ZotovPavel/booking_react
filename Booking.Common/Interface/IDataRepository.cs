using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Common.Interface
{
    public interface IDataRepository<TEntity> where TEntity: class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
