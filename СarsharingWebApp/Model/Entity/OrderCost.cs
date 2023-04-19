namespace СarsharingWebApp.Model.Entity
{
    public class OrderCost
    {
        public int Id { get; set; }
        public double Cost { get; set; }

        public OrderCost()
        {
            Id = default;
            Cost = 0;
        }

        public OrderCost(int id, double cost)
        {
            Id = id;
            Cost = cost;
        }
    }
}
