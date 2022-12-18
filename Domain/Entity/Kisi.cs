using A_Domain.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Domain.Entity
{
    public class Kisi : IEntity
    {
        public int ID { get; set; }
        public string İsim { get; set; }
        public string Soyisim { get; set; }
        public string NickName { get; set; }
        public string Açıklama { get; set; }
        public string Adres { get; set; }
        public DateTime? DoğumTarihi { get; set; }
        public virtual ICollection<İletişimNumarası> IletisimNumaralari { get; set; }
        public virtual ICollection<Mail> Mailler { get; set; }
        public virtual ICollection<KisiGruplari> KisiGruplari { get; set; }

        public Kisi()
        {
            this.IletisimNumaralari = new HashSet<İletişimNumarası>();
            this.Mailler = new HashSet<Mail>();
            this.KisiGruplari= new HashSet<KisiGruplari>();
        }

    }
  
   
}
