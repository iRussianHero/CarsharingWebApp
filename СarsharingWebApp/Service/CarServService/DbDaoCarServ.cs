using Microsoft.EntityFrameworkCore;
using OrderApiApp.Service.ClientService;
using СarsharingWebApp.Model;
using СarsharingWebApp.Model.Entity;

namespace СarsharingWebApp.Service.CarServService
{
    public class DbDaoCarServ : IDaoCarServ
    {
        private static List<CarServ> _carServ = new List<CarServ>();
        private static int currentId = 1;
        private ApplicationDbContext db;

        public DbDaoCarServ(ApplicationDbContext db)
        {
            this.db = db;
        }


        public async Task<CarServ> AddAsync(CarServ carService)
        {
            await db.AddAsync(carService);
            await db.SaveChangesAsync();
            return carService;
        }

        public async Task<CarServ> DeleteAsync(CarServ carService)
        {
            if (await db.CarServ.FirstOrDefaultAsync() != null)
            {
                db.CarServ.Remove(carService);
                await db.SaveChangesAsync();
            }
            return carService;
        }

        public Task<List<CarServ>> GetAllAsync()
        {
            return db.CarServ.ToListAsync();
        }

        public async Task<CarServ> GetAsync(CarServ carService)
        {
            return await db.CarServ.FirstOrDefaultAsync(p => p.Id == carService.Id);
        }

        public async Task<CarServ> UpdateAsync(CarServ carService)
        {
            if (await db.CarServ.FirstOrDefaultAsync() != null)
            {
                db.CarServ.Update(carService);
                await db.SaveChangesAsync();
                return carService;
            }
            return carService;
        }
    }
}
