using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kullanici :IEntity
    {
        public int ID { get; set; }
        public int SICIL_ID{ get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string SIFRE { get; set; }
        public bool  IS_ACTIVE{ get; set; }
        public bool IS_AUTHORIZED { get; set; }
    
    }
}
