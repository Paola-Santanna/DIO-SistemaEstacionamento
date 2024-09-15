namespace ParkSystemDIO.Domain.Commands.PostVehicle;
public class VehiclePostCommandRequest
{
    public string VehicleType { get; set; }
    public string VehicleModel { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public string Owner { get; set; }
    public string LicensePlate { get; set; }
    public int TotalHorsParked { get; set; }
    public float FinalPriceToPay { get; set; }

    public VehiclePostCommandRequest(
        string vehicleType, 
        string vehicleModel, 
        int year, string color, 
        string owner, 
        string licensePlate, 
        int totalHorsParked, 
        float finalPriceToPay)
    {
        VehicleType = vehicleType;
        VehicleModel = vehicleModel;
        Year = year;
        Color = color;
        Owner = owner;
        LicensePlate = licensePlate;
        TotalHorsParked = totalHorsParked;
        FinalPriceToPay = finalPriceToPay;
    }
}
