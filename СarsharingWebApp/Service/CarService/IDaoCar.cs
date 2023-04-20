using СarsharingWebApp.Model.Entity;

namespace OrderApiApp.Service.ClientService
{
    public interface IDaoCar
    {
        Task<List<Car>> GetAllAsync();
        Task<Car> AddAsync(Car car);
        Task<Car> UpdateAsync(Car car);
        Task<Car> DeleteAsync(Car car);
        Task<Car> GetAsync(Car car);
    }
}
