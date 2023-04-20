using СarsharingWebApp.Model.Entity;

namespace OrderApiApp.Service.ClientService
{
    public interface IDaoOrderCost
    {
        Task<List<OrderCost>> GetAllAsync();
        Task<OrderCost> AddAsync(OrderCost OrderCost);
        Task<OrderCost> UpdateAsync(OrderCost OrderCost);
        Task<OrderCost> DeleteAsync(OrderCost OrderCost);
        Task<OrderCost> GetAsync(OrderCost OrderCost);
    }
}
