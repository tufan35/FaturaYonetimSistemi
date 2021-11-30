using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Konut : IEntity
    {
        public int ID { get; set; }
        public Sicil SICIL_ID { get; set; }
        public int DAIRE_NO { get; set; }
        public int BLOK_NO { get; set; }
        public int KAT_NO { get; set; }
        public bool KONUT_DURUMU { get; set; }
        public int KONUT_TIPID { get; set; }


    }
}
