using Microsoft.EntityFrameworkCore;
using OrderApiApp.Service.ClientService;
using СarsharingWebApp.Model;
using СarsharingWebApp.Model.Entity;

namespace СarsharingWebApp.Service.CarConditionService
{
    public class DbDaoCarCondition : IDaoCarCondition
    {
        private static List<CarCondition>_carCondition = new List<CarCondition>();
        private static int currentId = 1;
        private ApplicationDbContext db;

        public DbDaoCarCondition(ApplicationDbContext db)
        {
            this.db = db;
        }


        public async Task<CarCondition> AddAsync(CarCondition carCondition)
        {
            await db.AddAsync(carCondition);
            await db.SaveChangesAsync();
            return carCondition;
        }

        public async Task<CarCondition> DeleteAsync(CarCondition carCondition)
        {
            if (await db.CarCondition.FirstOrDefaultAsync() != null)
            {
                db.CarCondition.Remove(carCondition);
                await db.SaveChangesAsync();
            }
            return carCondition;
        }

        public Task<List<CarCondition>> GetAllAsync()
        {
            return db.CarCondition.ToListAsync();
        }

        public async Task<CarCondition> GetAsync(CarCondition carCondition)
        {
            return await db.CarCondition.FirstOrDefaultAsync(p => p.Id == carCondition.Id);
        }

        public async Task<CarCondition> UpdateAsync(CarCondition carCondition)
        {
            if (await db.CarCondition.FirstOrDefaultAsync() != null)
            {
                db.CarCondition.Update(carCondition);
                await db.SaveChangesAsync();
                return carCondition;
            }
            return carCondition;
        }
    }
}
