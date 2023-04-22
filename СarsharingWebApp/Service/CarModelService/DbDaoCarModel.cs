using Microsoft.EntityFrameworkCore;
using OrderApiApp.Service.ClientService;
using СarsharingWebApp.Model;
using СarsharingWebApp.Model.Entity;

namespace СarsharingWebApp.Service.CarModelService
{
    public class DbDaoCarModel : IDaoCarModel
    {
        private static List<CarModel> _carModel = new List<CarModel>();
        private static int currentId = 1;
        private ApplicationDbContext db;

        public DbDaoCarModel(ApplicationDbContext db)
        {
            this.db = db;
        }


        public async Task<CarModel> AddAsync(CarModel carModel)
        {
            await db.AddAsync(carModel);
            await db.SaveChangesAsync();
            return carModel;
        }

        public async Task<CarModel> DeleteAsync(CarModel carModel)
        {
            if (await db.CarModel.FirstOrDefaultAsync() != null)
            {
                db.CarModel.Remove(carModel);
                await db.SaveChangesAsync();
            }
            return carModel;
        }

        public Task<List<CarModel>> GetAllAsync()
        {
            return db.CarModel.ToListAsync();
        }

        public async Task<CarModel> GetAsync(CarModel carModel)
        {
            return await db.CarModel.FirstOrDefaultAsync(p => p.Id == carModel.Id);
        }

        public async Task<CarModel> UpdateAsync(CarModel carModel)
        {
            if (await db.Client.FirstOrDefaultAsync() != null)
            {
                db.CarModel.Update(carModel);
                await db.SaveChangesAsync();
                return carModel;
            }
            return carModel;
        }
    }
}
