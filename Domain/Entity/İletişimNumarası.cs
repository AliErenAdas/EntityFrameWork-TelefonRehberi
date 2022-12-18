using System.ComponentModel.DataAnnotations;
using A_Domain.Abstract;
using A_Domain.Entity.Enums;

namespace A_Domain.Entity
{
    public class İletişimNumarası : IEntity
    {
        public int ID { get; set; }
        public int TürID { get; set; }
        public virtual İletişimTür Türü { get; set; }
        
        [Required]
        public int Numara { get; set; }
        public int KisiID { get; set; }
        public virtual Kisi Kisi { get; set; }
    }
  
   
}
