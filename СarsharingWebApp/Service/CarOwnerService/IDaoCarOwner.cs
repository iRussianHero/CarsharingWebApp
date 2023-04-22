using СarsharingWebApp.Model.Entity;

namespace OrderApiApp.Service.ClientService
{
    public interface IDaoCarOwner
    {
        Task<List<CarOwner>> GetAllAsync();
        Task<CarOwner> AddAsync(CarOwner carOwner);
        Task<CarOwner> UpdateAsync(CarOwner carOwner);
        Task<CarOwner> DeleteAsync(CarOwner carOwner);
        Task<CarOwner> GetAsync(CarOwner carOwner);
    }
}
