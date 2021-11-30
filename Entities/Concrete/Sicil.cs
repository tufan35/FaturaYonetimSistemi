using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Sicil :IEntity
    {
        public int ID { get; set; }
        public string KIMLIK_NO { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string EMAIL { get; set; }
        public string TELEFON { get; set; }
        public string ARAC_PLAKA_NO { get; set; }
        
    }
}
