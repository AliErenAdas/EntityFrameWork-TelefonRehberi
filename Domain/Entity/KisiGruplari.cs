using A_Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Domain.Entity
{
    public class KisiGruplari : IEntity
    {
        public int ID { get; set; }
        public int KisiID { get; set; }
        public virtual Kisi Kisi { get; set; }

        public int GrupID { get; set; }
        public virtual Grup Grup { get; set; }
    }
}
