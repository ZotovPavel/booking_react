using Booking.Common.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.DAL.Concrete
{
    public class Repository<TEntity> : IDataRepository<TEntity> where TEntity : class
    {
        private readonly BookingContext _context;

        public Repository(BookingContext context)
        {
            _context = context;
        }

        private DbSet<TEntity> DbSet
        {
            get { return _context.Set<TEntity>(); }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet;
        }

        public TEntity Get(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
            _context.SaveChanges();
        }
    }
}
