using СarsharingWebApp.Model.Entity;

namespace OrderApiApp.Service.ClientService
{
    public interface IDaoCarServ
    {
        Task<List<CarServ>> GetAllAsync();
        Task<CarServ> AddAsync(CarServ carServ);
        Task<CarServ> UpdateAsync(CarServ carServ);
        Task<CarServ> DeleteAsync(CarServ carServ);
        Task<CarServ> GetAsync(CarServ carServ);
    }
}
