using A_Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Domain.Entity
{
    public class Grup : IEntity
    {
        public int ID { get; set; }
        public string GrupAdı { get; set; }
        public virtual ICollection<KisiGruplari> KisiGruplari { get; set; }

        public Grup()
        {
            this.KisiGruplari = new HashSet<KisiGruplari>();
        }

    }
}
