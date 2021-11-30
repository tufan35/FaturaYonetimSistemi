using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
  public  interface IGenericRepository<T> where T : class , IEntity, new()
    {

        List<T> HepsiniGetir(Expression<Func<T,bool>> filter =null);
        T Getir(Expression<Func<T,bool>>filter);

        void kaydet(T obj);
        void sil(T obj);
        void guncelle(T obj);


    }
}
