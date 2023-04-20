using СarsharingWebApp.Model.Entity;

namespace OrderApiApp.Service.ClientService
{
    public interface IDaoOrderRate
    {
        Task<List<OrderRate>> GetAllAsync();
        Task<OrderRate> AddAsync(OrderRate oderRate);
        Task<OrderRate> UpdateAsync(OrderRate orderRate);
        Task<OrderRate> DeleteAsync(OrderRate orderRate);
        Task<OrderRate> GetAsync(OrderRate orderRate);
    }
}
