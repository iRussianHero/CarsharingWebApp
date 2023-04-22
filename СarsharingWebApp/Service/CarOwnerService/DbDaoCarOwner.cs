using Microsoft.EntityFrameworkCore;
using OrderApiApp.Service.ClientService;
using СarsharingWebApp.Model;
using СarsharingWebApp.Model.Entity;

namespace СarsharingWebApp.Service.CarCarOwner
{
    public class DbDaoCarOwner : IDaoCarOwner
    {
        private static List<CarOwner> _carOwner = new List<CarOwner>();
        private static int currentId = 1;
        private ApplicationDbContext db;

        public DbDaoCarOwner(ApplicationDbContext db)
        {
            this.db = db;
        }


        public async Task<CarOwner> AddAsync(CarOwner carOwner)
        {
            await db.AddAsync(carOwner);
            await db.SaveChangesAsync();
            return carOwner;
        }

        public async Task<CarOwner> DeleteAsync(CarOwner carOwner)
        {
            if (await db.CarOwner.FirstOrDefaultAsync() != null)
            {
                db.CarOwner.Remove(carOwner);
                await db.SaveChangesAsync();
            }
            return carOwner;
        }

        public Task<List<CarOwner>> GetAllAsync()
        {
            return db.CarOwner.ToListAsync();
        }

        public async Task<CarOwner> GetAsync(CarOwner carOwner)
        {
            return await db.CarOwner.FirstOrDefaultAsync(p => p.Id == carOwner.Id);
        }

        public async Task<CarOwner> UpdateAsync(CarOwner carOwner)
        {
            if (await db.CarOwner.FirstOrDefaultAsync() != null)
            {
                db.CarOwner.Update(carOwner);
                await db.SaveChangesAsync();
                return carOwner;
            }
            return carOwner;
        }
    }
}
