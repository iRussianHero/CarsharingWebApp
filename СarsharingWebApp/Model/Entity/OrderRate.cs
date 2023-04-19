namespace СarsharingWebApp.Model.Entity
{
    public class OrderRate
    {
        public int Id { get; set; }
        public int OrderCostId { get; set; }
        public string Name { get; set; }

        public OrderRate()
        {
            Id = default;
            OrderCostId = default;
            Name = "";
        }

        public OrderRate(int id, int orderCostId, string name)
        {
            Id = id;
            OrderCostId = orderCostId;
            Name = name;
        }
    }
}
