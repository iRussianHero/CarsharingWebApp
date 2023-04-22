using Microsoft.EntityFrameworkCore;
using OrderApiApp.Service.ClientService;
using СarsharingWebApp.Model;
using СarsharingWebApp.Model.Entity;

namespace СarsharingWebApp.Service.CarBrandService
{
    public class DbDaoCarBrand : IDaoCarBrand
    {
        private static List<CarBrand> _carBrand = new List<CarBrand>();
        private static int currentId = 1;
        private ApplicationDbContext db;

        public DbDaoCarBrand(ApplicationDbContext db)
        {
            this.db = db;
        }


        public async Task<CarBrand> AddAsync(CarBrand carBrand)
        {
            await db.AddAsync(carBrand);
            await db.SaveChangesAsync();
            return carBrand;
        }

        public async Task<CarBrand> DeleteAsync(CarBrand carBrand)
        {
            if (await db.CarBrand.FirstOrDefaultAsync() != null)
            {
                db.CarBrand.Remove(carBrand);
                await db.SaveChangesAsync();
            }
            return carBrand;
        }

        public Task<List<CarBrand>> GetAllAsync()
        {
            return db.CarBrand.ToListAsync();
        }

        public async Task<CarBrand> GetAsync(CarBrand carBrand)
        {
            return await db.CarBrand.FirstOrDefaultAsync(p => p.Id == carBrand.Id);
        }

        public async Task<CarBrand> UpdateAsync(CarBrand carBrand)
        {
            if (await db.Client.FirstOrDefaultAsync() != null)
            {
                db.CarBrand.Update(carBrand);
                await db.SaveChangesAsync();
                return carBrand;
            }
            return carBrand;
        }
    }
}
