using ParkSystemDIO.Domain.Entities;
using ParkSystemDIO.Domain.Interfaces;

namespace ParkSystemDIO.Domain.Commands.PostVehicle;
public class VehiclePostCommandHandler : IVehicle
{
    public Vehicle RegisterVehicle(VehiclePostCommandRequest request)
    {
        var newVehicle = new Vehicle();

        if(request != null)
        {
            newVehicle.VehicleType = request.VehicleType;
            newVehicle.VehicleModel = request.VehicleModel;
            newVehicle.Year = request.Year;
            newVehicle.Color = request.Color;
            newVehicle.Owner = request.Owner;
            newVehicle.LicensePlate = request.LicensePlate;
            newVehicle.TotalHorsParked = request.TotalHorsParked;
            newVehicle.FinalPriceToPay = request.FinalPriceToPay;

            return newVehicle;
        }
        else
        {
            throw new ArgumentNullException(nameof(request));
        }
    }

    public float RegisterHourPrice(float price)
    {
        throw new NotImplementedException();
    }

    public float CalculateFinalPrice(float pricePerHour, float totalHoursParked)
    {
        throw new NotImplementedException();
    }
}