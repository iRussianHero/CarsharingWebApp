using Microsoft.EntityFrameworkCore;
using OrderApiApp.Service.ClientService;
using СarsharingWebApp.Model;
using СarsharingWebApp.Model.Entity;

namespace СarsharingWebApp.Service.OrderCostService
{
    public class DbDaoOrderCost : IDaoOrderCost
    {
        private static List<OrderCost> _orderCost = new List<OrderCost>();
        private static int currentId = 1;
        private ApplicationDbContext db;

        public DbDaoOrderCost(ApplicationDbContext db)
        {
            this.db = db;
        }


        public async Task<OrderCost> AddAsync(OrderCost orderCost)
        {
            await db.AddAsync(orderCost);
            await db.SaveChangesAsync();
            return orderCost;
        }

        public async Task<OrderCost> DeleteAsync(OrderCost orderCost)
        {
            if (await db.OrderCost.FirstOrDefaultAsync() != null)
            {
                db.OrderCost.Remove(orderCost);
                await db.SaveChangesAsync();
            }
            return orderCost;
        }

        public Task<List<OrderCost>> GetAllAsync()
        {
            return db.OrderCost.ToListAsync();
        }

        public async Task<OrderCost> GetAsync(OrderCost orderCost)
        {
            return await db.OrderCost.FirstOrDefaultAsync(p => p.Id == orderCost.Id);
        }

        public async Task<OrderCost> UpdateAsync(OrderCost orderCost)
        {
            if (await db.OrderCost.FirstOrDefaultAsync() != null)
            {
                db.OrderCost.Update(orderCost);
                await db.SaveChangesAsync();
                return orderCost;
            }
            return orderCost;
        }
    }
}
