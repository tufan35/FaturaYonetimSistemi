using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FaturaManager : IFaturaService
    {

        private IFaturaDal _faturaDal;
        public FaturaManager(IFaturaDal faturaDal)
        {
            _faturaDal = faturaDal;
        }

        public Fatura Getir(int ID)
        {
            return _faturaDal.Getir(f => f.ID ==ID);
        }

        public void guncelle(Fatura fatura)
        {
            _faturaDal.guncelle(fatura) ;
        }

        public List<Fatura> HepsiniGetir()
        {
            return _faturaDal.HepsiniGetir();
        }

        public void kaydet(Fatura fatura)
        {
            _faturaDal.kaydet(fatura);
        }

        public void sil(Fatura fatura)
        {
            throw new NotImplementedException();
        }

     
    }
}
