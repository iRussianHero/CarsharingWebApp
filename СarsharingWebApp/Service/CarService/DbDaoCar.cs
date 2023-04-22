using Microsoft.EntityFrameworkCore;
using OrderApiApp.Service.ClientService;
using СarsharingWebApp.Model;
using СarsharingWebApp.Model.Entity;

namespace СarsharingWebApp.Service.CarService
{
    public class DbDaoCar : IDaoCar
    {
        private static List<Car> _car = new List<Car>();
        private static int currentId = 1;
        private ApplicationDbContext db;

        public DbDaoCar(ApplicationDbContext db)
        {
            this.db = db;
        }


        public async Task<Car> AddAsync(Car car)
        {
            await db.AddAsync(car);
            await db.SaveChangesAsync();
            return car;
        }

        public async Task<Car> DeleteAsync(Car carBrand)
        {
            if (await db.Car.FirstOrDefaultAsync() != null)
            {
                db.Car.Remove(carBrand);
                await db.SaveChangesAsync();
            }
            return carBrand;
        }

        public Task<List<Car>> GetAllAsync()
        {
            return db.Car.ToListAsync();
        }

        public async Task<Car> GetAsync(Car carBrand)
        {
            return await db.Car.FirstOrDefaultAsync(p => p.Id == carBrand.Id);
        }

        public async Task<Car> UpdateAsync(Car carBrand)
        {
            if (await db.Car.FirstOrDefaultAsync() != null)
            {
                db.Car.Update(carBrand);
                await db.SaveChangesAsync();
                return carBrand;
            }
            return carBrand;
        }
    }
}
