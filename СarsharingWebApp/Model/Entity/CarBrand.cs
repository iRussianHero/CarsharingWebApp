namespace СarsharingWebApp.Model.Entity
{
    public class CarBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CarBrand()
        {
            Id = default;
            Name = "";
        }

        public CarBrand(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
