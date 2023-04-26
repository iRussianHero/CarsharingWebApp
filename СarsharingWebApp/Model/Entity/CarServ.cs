using System.Text.Json.Serialization;

namespace СarsharingWebApp.Model.Entity
{
    public class CarServ
    {
        public int Id { get; set; }
        public DateTime ServiceDay { get; set; }
        public DateTime LastService { get; set; }
        public DateTime NextService { get; set; }
        public int CurrentMilage { get; set; }
        public int NextServiceMilage { get; set; }


        [JsonIgnore]
        public Car? Car { get; set; }


        public CarServ()
        {
            Id = default;
            ServiceDay = default;
            LastService = new DateTime(2000, 1, 1);
            NextService = default;
            CurrentMilage = default;
            NextServiceMilage = default;
        }

        public CarServ(int id, DateTime serviceDay, DateTime lastService, DateTime nextService, int currentMilage, int nextServiceMilage)
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
