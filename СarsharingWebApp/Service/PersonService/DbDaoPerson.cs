using Microsoft.EntityFrameworkCore;
using OrderApiApp.Service.ClientService;
using СarsharingWebApp.Model;
using СarsharingWebApp.Model.Entity;

namespace СarsharingWebApp.Service.PersonService
{
    public class DbDaoPerson : IDaoPerson
    {
        private static List<Person> _person = new List<Person>();
        private static int currentId = 1;
        private ApplicationDbContext db;

        public DbDaoPerson(ApplicationDbContext db)
        {
            this.db = db;
        }


        public async Task<Person> AddAsync(Person person)
        {
            await db.AddAsync(person);
            await db.SaveChangesAsync();
            return person;
        }

        public async Task<Person> DeleteAsync(Person person)
        {
            if (await db.Person.FirstOrDefaultAsync() != null)
            {
                db.Person.Remove(person);
                await db.SaveChangesAsync();
            }
            return person;
        }

        public Task<List<Person>> GetAllAsync()
        {
            return db.Person.ToListAsync();
        }

        public async Task<Person> GetAsync(Person person)
        {
            return await db.Person.FirstOrDefaultAsync(p => p.Id == person.Id);
        }

        public async Task<Person> UpdateAsync(Person person)
        {
            if (await db.Client.FirstOrDefaultAsync() != null)
            {
                db.Person.Update(person);
                await db.SaveChangesAsync();
                return person;
            }
            return person;
        }
    }
}
