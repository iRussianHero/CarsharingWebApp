namespace СarsharingWebApp.Model.Entity
{
    public class OrderRate
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public string Name { get; set; }

        public OrderRate()
        {
            Id = default;
            Cost = default;
            Name = "";
        }

        public OrderRate(int id, int cost, string name)
        {
            Id = id;
            Cost = cost;
            Name = name;
        }
    }
}
