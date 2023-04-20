using СarsharingWebApp.Model.Entity;

namespace OrderApiApp.Service.ClientService
{
    public interface IDaoCarModel
    {
        Task<List<CarModel>> GetAllAsync();
        Task<CarModel> AddAsync(CarModel carModel);
        Task<CarModel> UpdateAsync(CarModel carModel);
        Task<CarModel> DeleteAsync(CarModel carModel);
        Task<CarModel> GetAsync(CarModel carModel);
    }
}
