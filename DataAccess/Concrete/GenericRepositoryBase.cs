using DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class GenericRepositoryBase<TObj, TDB> : IGenericRepository<TObj>
         where TObj : class, IEntity, new()
         where TDB : DbContext, new()
    {
        public TObj Getir(Expression<Func<TObj, bool>> filter)
        {
            using (TDB dbset = new TDB()) 
            {

                return dbset.Set<TObj>().SingleOrDefault(filter);
            }
        }

        public void guncelle(TObj obj)
        {
            using (TDB dbset = new TDB()) 
            {
                var guncelle = dbset.Entry(obj);
                guncelle.State = EntityState.Modified;
                dbset.SaveChanges();
            
            }
        }

        public List<TObj> HepsiniGetir(Expression<Func<TObj, bool>> filter = null)
        {
            using (TDB dbset = new TDB())
            {
                return filter == null 
                ? dbset.Set<TObj>().ToList() 
                : dbset.Set<TObj>().Where(filter).ToList();
            }
        }

        public void kaydet(TObj obj)
        {
            using (TDB dbset = new TDB())
            {

                var kaydet = dbset.Entry(obj);
                kaydet.State = EntityState.Added;
                dbset.SaveChanges();
            
            }
        }

        public void sil(TObj obj)
        {

            //kodlanacak
            throw new NotImplementedException();
        }
    }
}
