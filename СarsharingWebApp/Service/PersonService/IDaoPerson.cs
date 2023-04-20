using СarsharingWebApp.Model.Entity;

namespace OrderApiApp.Service.ClientService
{
    public interface IDaoPerson
    {
        Task<List<Person>> GetAllAsync();
        Task<Person> AddAsync(Person person);
        Task<Person> UpdateAsync(Person person);
        Task<Person> DeleteAsync(Person person);
        Task<Person> GetAsync(Person person);
    }
}
