using СarsharingWebApp.Model.Entity;

namespace OrderApiApp.Service.ClientService
{
    public interface IDaoCarCondition
    {
        Task<List<CarBrand>> GetAllAsync();
        Task<CarBrand> AddAsync(CarBrand carBrand);
        Task<CarBrand> UpdateAsync(CarBrand carBrand);
        Task<CarBrand> DeleteAsync(CarBrand carBrand);
        Task<CarBrand> GetAsync(CarBrand carBrand);
    }
}
