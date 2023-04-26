using Microsoft.Extensions.Hosting;
using System.Text.Json.Serialization;

namespace СarsharingWebApp.Model.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public int CarBrandId { get; set; }
        public int CarModelId { get; set; }
        public int CarConditionId { get; set; }
        public int CarOwnerId { get; set; }
        public string CarNumber { get; set; }
        public string CarMilage { get; set; }



        [JsonIgnore]
        public CarBrand? CarBrand { get; set; }
        [JsonIgnore]
        public CarModel? CarModel { get; set; }
        [JsonIgnore]
        public CarCondition? CarCondition { get; set; }
        [JsonIgnore]
        public CarOwner? CarOwner { get; set; }


        public Car()
        {
            Id = default;
            CarBrandId = default;
            CarModelId = default;
            CarConditionId = default;
            CarOwnerId = default;
            CarNumber = "";
            CarMilage = "";
        }

        public Car(int id, int carBrandId, int carModelId, int carConditionId, int carOwnerId, string carNumber, string carMilage)
        {
            Id = id;
            CarBrandId = carBrandId;
            CarModelId = carModelId;
            CarConditionId = carConditionId;
            CarOwnerId = carOwnerId;
            CarNumber = carNumber;
            CarMilage = carMilage;
        }
    }
}
