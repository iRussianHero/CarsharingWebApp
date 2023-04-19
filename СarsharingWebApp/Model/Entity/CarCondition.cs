namespace СarsharingWebApp.Model.Entity
{
    public class CarCondition
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CarCondition()
        {
            Id = default;
            Name = "";
        }

        public CarCondition(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
