using СarsharingWebApp.Model.Entity;

namespace OrderApiApp.Service.ClientService
{
    public interface IDaoCarService
    {
        Task<List<CarService>> GetAllAsync();
        Task<CarService> AddAsync(CarService carService);
        Task<CarService> UpdateAsync(CarService carService);
        Task<CarService> DeleteAsync(CarService carService);
        Task<CarService> GetAsync(CarService carService);
    }
}
