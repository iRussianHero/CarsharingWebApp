using Microsoft.EntityFrameworkCore;
using OrderApiApp.Service.ClientService;
using СarsharingWebApp.Model;
using СarsharingWebApp.Model.Entity;

namespace СarsharingWebApp.Service.ClientService
{
    public class DbDaoClient : IDaoClient
    {
        private static List<Client> _carClient = new List<Client>();
        private static int currentId = 1;
        private ApplicationDbContext db;

        public DbDaoClient(ApplicationDbContext db)
        {
            this.db = db;
        }


        public async Task<Client> AddAsync(Client client)
        {
            await db.AddAsync(client);
            await db.SaveChangesAsync();
            return client;
        }

        public async Task<Client> DeleteAsync(Client client)
        {
            if (await db.Client.FirstOrDefaultAsync() != null)
            {
                db.Client.Remove(client);
                await db.SaveChangesAsync();
            }
            return client;
        }

        public Task<List<Client>> GetAllAsync()
        {
            return db.Client.ToListAsync();
        }

        public async Task<Client> GetAsync(Client client)
        {
            return await db.Client.FirstOrDefaultAsync(p => p.Id == client.Id);
        }

        public async Task<Client> UpdateAsync(Client client)
        {
            if (await db.Client.FirstOrDefaultAsync() != null)
            {
                db.Client.Update(client);
                await db.SaveChangesAsync();
                return client;
            }
            return client;
        }
    }
}
