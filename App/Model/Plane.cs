using VehiclesApp.Model.Interfaces;

namespace VehiclesApp.Model
{
    public class Plane : Vehicle, IFlyable
    {
        public Plane(int year, string color, int crew) : base(year, color)
        {
            Type = Enums.VehicleType.Plane;
            Crew = crew;
        }

        public int Crew { get; set; }

        public override string Move() => "Flying...";
    }
}
