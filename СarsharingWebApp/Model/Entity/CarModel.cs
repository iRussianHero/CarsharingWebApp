namespace СarsharingWebApp.Model.Entity
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CarModel()
        {
            Id = default;
            Name = "";
        }

        public CarModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
