using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            FaturaManager faturaManager = new FaturaManager(new EfFaturaDal());

            foreach (var item in faturaManager.HepsiniGetir())
            {
                Console.WriteLine(item.FATURA_ADI);
            }
            Console.ReadLine();
                


        }
    }
}
