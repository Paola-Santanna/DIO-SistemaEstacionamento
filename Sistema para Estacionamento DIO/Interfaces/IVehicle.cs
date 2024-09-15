using ParkSystemDIO.Domain.Commands.PostVehicle;
using ParkSystemDIO.Domain.Entities;

namespace ParkSystemDIO.Domain.Interfaces;
public interface IVehicle
{
    public Vehicle RegisterVehicle(VehiclePostCommandRequest vehicleRequest);

    public float RegisterHourPrice(float price);

    public float CalculateFinalPrice(float pricePerHour, float totalHoursParked);
}
