namespace ParkSystemDIO.Domain.Entities;
public class Vehicle
{
    public string VehicleType { get; set; }
    public string VehicleModel { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public string Owner { get; set; }
    public string LicensePlate { get; set; }
    public int ID { get; set; }
    public int TotalHorsParked { get; set; }
    public float FinalPriceToPay { get; set; }

    public Vehicle()
    { }

    public Vehicle(
        string vehicleType, 
        string vehicleModel, 
        int year, 
        string color, 
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

    public float RegisterHourPrice()
    {
        Console.Clear();
        Console.WriteLine("\n>>>Welcome to the parking lot!<<<".ToUpper());

        Console.WriteLine("Enter the price per hour (Use comma for decimals)");
        float pricePerHour = float.Parse(Console.ReadLine());

        return pricePerHour;
    }

    public void RegisterVehicle()
    {
        Console.WriteLine("\nEnter the following information:");

        Console.WriteLine($"\nID: {this.ID}");
        Console.Write("Vehicle Type: ");
        this.VehicleType = Console.ReadLine();

        Console.Write("Vehicle Model: ");
        this.VehicleModel = Console.ReadLine();

        Console.Write("Vehicle year: ");
        this.Year = int.Parse(Console.ReadLine());

        Console.Write("Vehicle color: ");
        this.Color = Console.ReadLine();

        Console.Write("Vehicle owner: ");
        this.Owner = Console.ReadLine();

        Console.Write("Vehicle plate: ");
        this.LicensePlate = Console.ReadLine();
    }

    public void FinalPrice(float p)
    {
        Console.Write("\nTotal HOURS that the vehicle was parked: ");
        this.TotalHorsParked = int.Parse(Console.ReadLine());

        this.FinalPriceToPay = p * this.TotalHorsParked;

        Console.WriteLine($"\nPrice Per Hour: {p} \nFinal price: {this.FinalPriceToPay}");
    }

    public override string? ToString()
    {
        return $"Vehicle ID: {this.ID} \nVehicle Type: {this.VehicleType} " +
            $"\nVehicle Model: {this.VehicleModel} " +
            $"\nYear: {this.Year} " +
            $"\nColor: {this.Color} " +
            $"\nOwner: {this.Owner} " +
            $"\nVehicle plate: {this.LicensePlate} " +
            $"\nTotal Hours Parked: {this.TotalHorsParked} " +
            $"\nFinal price: {this.FinalPriceToPay}";
    }
}