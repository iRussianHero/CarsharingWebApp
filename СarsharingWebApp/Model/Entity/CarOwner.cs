using System.Xml.Linq;

namespace СarsharingWebApp.Model.Entity
{
    public class CarOwner
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public CarOwner()
        {
            Id = default;
            LastName = "";
            FirstName = "";
            CompanyName = "";
            Phone = "";
            Login = "";
            Password = "";
        }


        public CarOwner(int id, string lastName, string firstName, string companyName, string phone, string login, string password)
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
