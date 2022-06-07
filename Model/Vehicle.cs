using VehiclesApp.Model.Enums;
using VehiclesApp.Model.Interfaces;

namespace VehiclesApp.Model
{
    public abstract class Vehicle : IVehicle
    {
        public Vehicle(int year, string color)
        {
            Year = year;
            Color = color;
        }

        public Guid Id { get; init; } = Guid.NewGuid();
        public int Year { get ; init; }
        public string Color { get; set; }
        public VehicleType Type { get; set; }
        public abstract string Move();
    }
}
