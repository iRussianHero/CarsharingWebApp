using System.Xml.Linq;

namespace СarsharingWebApp.Model.Entity
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }


        public Person()
        {
            Id = default;
            FirstName = "";
            LastName = "";
            PhoneNumber = "";
        }

        public Person(int id, string firstName, string lastName, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
    }
}
