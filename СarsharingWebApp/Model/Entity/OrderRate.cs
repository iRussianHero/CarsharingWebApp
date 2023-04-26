namespace СarsharingWebApp.Model.Entity
{
    public class OrderRate
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int Cost { get; set; }
        public string Name { get; set; }

        public OrderRate()
        {
            Id = default;
            CarId = default;
            Cost = default;
            Name = "";
        }

        public OrderRate(int id, int carId, int cost, string name)
        {
            Id = id;
            CarId = carId;
            Cost = cost;
            Name = name;
        }
    }
}
