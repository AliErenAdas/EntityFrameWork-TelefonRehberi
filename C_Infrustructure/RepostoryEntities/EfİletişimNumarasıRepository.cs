using A_Domain.Entity;
using A_Domain.RepostoryInterface;
using C_Infrustructure.Data;

namespace C_Infrustructure.RepostoryEntities
{
    public class EfİletişimNumarasıRepository : EfEntityRepositoryBase<İletişimNumarası, TelefonRehberiDbContext>, IİletişimNumarasıRepository
    {
    }


}

