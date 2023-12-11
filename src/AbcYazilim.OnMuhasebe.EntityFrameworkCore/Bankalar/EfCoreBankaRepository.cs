﻿using AbcYazilim.OnMuhasebe.Commons;
using AbcYazilim.OnMuhasebe.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;

namespace AbcYazilim.OnMuhasebe.Bankalar;
public class EfCoreBankaRepository : EfCoreCommonRepository<Banka>,IBankaRepository
{
    public EfCoreBankaRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
