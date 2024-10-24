

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MasterFloor.Models.Repositories
{
    public class HistorySalesRepository
    {

        private readonly MasterFloorDbContext _dbContext;

        public HistorySalesRepository(MasterFloorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<HistorySale>> GetHistorySale() => await _dbContext.HistorySales.ToListAsync();

    }
}
