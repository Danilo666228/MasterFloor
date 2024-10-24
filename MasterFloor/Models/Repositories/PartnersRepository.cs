using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFloor.Models.Repositories
{
    public class PartnersRepository
    {
        private readonly MasterFloorDbContext _dbContext;

        public PartnersRepository(MasterFloorDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Partner>> GetPartners() => await _dbContext.Partners
            .Include(c => c.DiscountPartner)
            .Include(c=> c.PartnerType)
            .ToListAsync();
    }
}
