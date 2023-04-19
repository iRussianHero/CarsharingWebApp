namespace СarsharingWebApp.Model.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public int CarBrandId { get; set; }
        public int CarModelId { get; set; }
        public int CarConditionId { get; set; }
        public int CarServiceId { get; set; }
        public int CarOwnerId { get; set; }
        public string CarNumber { get; set; }
        public string CarMilage { get; set; }


        public Car()
        {
            Id = default;
            CarBrandId = default;
            CarModelId = default;
            CarConditionId = default;
            CarServiceId = default;
            CarOwnerId = default;
            CarNumber = "";
            CarMilage = "";
        }

        public Car(int id, int carBrandId, int carModelId, int carConditionId, int carServiceId, int carOwnerId, string carNumber, string carMilage)
        {
            Id = id;
            CarBrandId = carBrandId;
            CarModelId = carModelId;
            CarConditionId = carConditionId;
            CarServiceId = carServiceId;
            CarOwnerId = carOwnerId;
            CarNumber = carNumber;
            CarMilage = carMilage;
        }
    }
}
