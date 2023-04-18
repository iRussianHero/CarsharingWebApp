using System.Xml.Linq;

namespace СarsharingWebApp.Model.Entity
{
    public class CarOwner
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string CompanyName { get; set; }

        public CarOwner()
        {
            Id = default;
            PersonId = default;
            CompanyName = "";
        }


        public CarOwner(int id, int personId, string companyName)
        {
            Id = id;
            PersonId = personId;
            CompanyName = companyName;
        }
    }
}
