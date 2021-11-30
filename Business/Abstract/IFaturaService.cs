using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFaturaService
    {
        List<Fatura> HepsiniGetir();
        Fatura Getir(int ID);

        void kaydet(Fatura fatura);
        void sil(Fatura fatura);
        void guncelle(Fatura fatura);
    }
}
