using A_Domain.Abstract;
using A_Domain.Entity.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Domain.Entity
{
    public class İletişimTür : IEntity
    {
        public int ID { get; set; }
       
        public int İletişimNumarasıID { get; set; }
        public virtual ICollection<İletişimNumarası> iletişimNumaralarin { get; set; }
       
        public virtual İletişimNoTür iletişimNoTür { get; set; }

        public İletişimTür()
        {
            this.iletişimNumaralarin = new HashSet<İletişimNumarası>();
        }


    }

}
