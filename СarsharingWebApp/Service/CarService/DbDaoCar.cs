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

        public async Task<List<Car>> CarSearchAsync(string? carNumber, int? carBrand, int? carModel)
        {
            var result = new List<Car>();
            if (carNumber == "Гос. номер")
            {
                carNumber = null;
            }

            if (carNumber != null)
            {
                var carNumberResult = await db.Car.FirstOrDefaultAsync(p => p.CarNumber == carNumber);
                if (carNumberResult != null)
                {
                    result.Add(carNumberResult);
                }
            }
            if (carBrand != null)
            {
                var carNumberResult = await db.Car.FirstOrDefaultAsync(p => p.CarBrandId == carBrand);
                if (carNumberResult != null && result.Contains(carNumberResult) == false)
                {
                    result.Add(carNumberResult);
                }
            }
            if (carModel != null)
            {
                var carNumberResult = await db.Car.FirstOrDefaultAsync(p => p.CarModelId == carModel);
                if (carNumberResult != null && result.Contains(carNumberResult) == false)
                {
                    result.Add(carNumberResult);
                }
            }
            return result;
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
