using СarsharingWebApp.Model.Entity;

namespace OrderApiApp.Service.ClientService
{
    public interface IDaoCarCondition
    {
        Task<List<CarCondition>> GetAllAsync();
        Task<CarCondition> AddAsync(CarCondition carCondition);
        Task<CarCondition> UpdateAsync(CarCondition carCondition);
        Task<CarCondition> DeleteAsync(CarCondition carCondition);
        Task<CarCondition> GetAsync(CarCondition carCondition);
    }
}
