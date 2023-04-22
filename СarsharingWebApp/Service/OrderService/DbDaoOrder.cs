using Microsoft.EntityFrameworkCore;
using OrderApiApp.Service.ClientService;
using СarsharingWebApp.Model;
using СarsharingWebApp.Model.Entity;

namespace СarsharingWebApp.Service.CarOrderService
{
    public class DbDaoOrder : IDaoOrder
    {
        private static List<Order> _order = new List<Order>();
        private static int currentId = 1;
        private ApplicationDbContext db;

        public DbDaoOrder(ApplicationDbContext db)
        {
            this.db = db;
        }


        public async Task<Order> AddAsync(Order order)
        {
            await db.AddAsync(order);
            await db.SaveChangesAsync();
            return order;
        }

        public async Task<Order> DeleteAsync(Order order)
        {
            if (await db.Order.FirstOrDefaultAsync() != null)
            {
                db.Order.Remove(order);
                await db.SaveChangesAsync();
            }
            return order;
        }

        public Task<List<Order>> GetAllAsync()
        {
            return db.Order.ToListAsync();
        }

        public async Task<Order> GetAsync(Order order)
        {
            return await db.Order.FirstOrDefaultAsync(p => p.Id == order.Id);
        }

        public async Task<Order> UpdateAsync(Order order)
        {
            if (await db.Order.FirstOrDefaultAsync() != null)
            {
                db.Order.Update(order);
                await db.SaveChangesAsync();
                return order;
            }
            return order;
        }
    }
}
