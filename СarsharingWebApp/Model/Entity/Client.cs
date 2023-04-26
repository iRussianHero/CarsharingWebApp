namespace СarsharingWebApp.Model.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Client()
        {
            Id = default;
            LastName = "";
            FirstName = "";
            CompanyName = "";
            Phone = "";
            Login = "";
            Password = "";
        }


        public Client(int id, string lastName, string firstName, string companyName, string phone, string login, string password)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            CompanyName = companyName;
            Phone = phone;
            Login = login;
            Password = password;
        }
    }
}
