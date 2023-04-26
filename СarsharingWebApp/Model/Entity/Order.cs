using System.Text.Json.Serialization;

namespace СarsharingWebApp.Model.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int CarId { get; set; }
        public int OrderRateId { get; set; }
        public DateTime StartRent { get; set; }
        public DateTime StopRent { get; set; }
        public int StartMilage { get; set; }
        public int StopMilage { get; set; }
        public double Account { get; set; }



        [JsonIgnore]
        public Client? Client { get; set; }
        [JsonIgnore]
        public Car? Car { get; set; }
        [JsonIgnore]
        public OrderRate? OrderRate { get; set; }



        public Order()
        {
            Id = default;
            ClientId = default;
            CarId = default;
            OrderRateId = default;
            StartRent = new DateTime(2000, 1, 1);
            StopRent = new DateTime(2000, 1, 1);
            StartMilage = 0;
            StopMilage = 0;
            Account = 0.0;
        }

        public Order(int id, int clientId, int carId, int orderRateId, DateTime startRent, DateTime stopRent, int startMilage, int stopMilage, double account)
        {
            Id = id;
            ClientId = clientId;
            CarId = carId;
            OrderRateId = orderRateId;
            StartRent = startRent;
            StopRent = stopRent;
            StartMilage = startMilage;
            StopMilage = stopMilage;
            Account = account;
        }
    }
}
