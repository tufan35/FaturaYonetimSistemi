using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public  class Konut_Tip :IEntity
    {
        public int ID { get; set; }
        public int KONUT_TIPI { get; set; }
    }
}
