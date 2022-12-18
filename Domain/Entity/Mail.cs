using A_Domain.Abstract;

namespace A_Domain.Entity
{
    public class Mail : IEntity
    {
        public int ID { get; set; }
        public string MailAdresi { get; set; }
        public int KisiID { get; set; }

        public virtual Kisi Kisi { get; set; }

    }
  
   
}
