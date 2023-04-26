namespace СarsharingWebApp.Model.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }


        public Client()
        {
            Id = default;
            LastName = "";
            FirstName = "";
            Phone = "";
        }


        public Client(int id, string lastName, string firstName, string phone)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Phone = phone;
        }
    }
}
