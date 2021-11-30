using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Fatura : IEntity
    {
       
        
        public int ID { get; set; }
        public int FATURA_TIP { get; set; }
        public  int FATURA_NO { get; set; }
        public string FATURA_ADI { get; set; }
        public decimal FATURA_TUTAR { get; set; }
        public int KONUTID { get; set; }


    }
}
