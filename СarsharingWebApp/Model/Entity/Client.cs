namespace СarsharingWebApp.Model.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int DriverLicense { get; set; }

        public Client()
        {
            Id = default;
            PersonId = default;
            DriverLicense = default;
        }

        public Client(int id, int personId, int driverLicense)
        {
            Id = id;
            PersonId = personId;
            DriverLicense = driverLicense;
        }
    }
}
