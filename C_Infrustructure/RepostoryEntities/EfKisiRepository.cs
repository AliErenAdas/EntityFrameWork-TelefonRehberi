﻿using A_Domain.Entity;
using A_Domain.RepostoryInterface;
using C_Infrustructure.Data;

namespace C_Infrustructure.RepostoryEntities
{
    public class EfKisiRepository : EfEntityRepositoryBase<Kisi, TelefonRehberiDbContext>, IKisiRepository
    {
    }


}

