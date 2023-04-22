using Microsoft.EntityFrameworkCore;
using OrderApiApp.Service.ClientService;
using СarsharingWebApp.Model;
using СarsharingWebApp.Model.Entity;

namespace СarsharingWebApp.Service.OrderRateService
{
    public class DbDaoOrderRate : IDaoOrderRate
    {
        private static List<OrderRate> _orderRate = new List<OrderRate>();
        private static int currentId = 1;
        private ApplicationDbContext db;

        public DbDaoOrderRate(ApplicationDbContext db)
        {
            this.db = db;
        }


        public async Task<OrderRate> AddAsync(OrderRate orderRate)
        {
            await db.AddAsync(orderRate);
            await db.SaveChangesAsync();
            return orderRate;
        }

        public async Task<OrderRate> DeleteAsync(OrderRate orderRate)
        {
            if (await db.OrderRate.FirstOrDefaultAsync() != null)
            {
                db.OrderRate.Remove(orderRate);
                await db.SaveChangesAsync();
            }
            return orderRate;
        }

        public Task<List<OrderRate>> GetAllAsync()
        {
            return db.OrderRate.ToListAsync();
        }

        public async Task<OrderRate> GetAsync(OrderRate orderRate)
        {
            return await db.OrderRate.FirstOrDefaultAsync(p => p.Id == orderRate.Id);
        }

        public async Task<OrderRate> UpdateAsync(OrderRate orderRate)
        {
            if (await db.OrderRate.FirstOrDefaultAsync() != null)
            {
                db.OrderRate.Update(orderRate);
                await db.SaveChangesAsync();
                return orderRate;
            }
            return orderRate;
        }
    }
}
