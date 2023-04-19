namespace СarsharingWebApp.Model.Entity
{
    public class CarService
    {
        public int Id { get; set; }
        public DateTime ServiceDay { get; set; }
        public DateTime LastService { get; set; }
        public DateTime NextService { get; set; }
        public int CurrentMilage { get; set; }
        public int NextServiceMilage { get; set; }

        public CarService()
        {
            Id = default;
            ServiceDay = default;
            LastService = new DateTime(2000, 1, 1);
            NextService = default;
            CurrentMilage = default;
            NextServiceMilage = default;
        }

        public CarService(int id, DateTime serviceDay, DateTime lastService, DateTime nextService, int currentMilage, int nextServiceMilage)
        {
            Id = id;
            ServiceDay = serviceDay;
            LastService = lastService;
            NextService = nextService;
            CurrentMilage = currentMilage;
            NextServiceMilage = nextServiceMilage;
        }
    }
}
