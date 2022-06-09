using VehiclesApp.Model.Enums;
namespace VehiclesApp.Model.Interfaces
{
    public interface IVehicle
    {
        Guid Id { get; init; }
        int Year { get; init; }
        string Color { get; set; }
        VehicleType Type { get; set; }
    }
}
