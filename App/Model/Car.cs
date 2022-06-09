namespace VehiclesApp.Model
{
    public class Car : Vehicle
    {
        public Car(int year, string color) : base(year, color)
        {
            Type = Enums.VehicleType.Car;
        }
        public override string Move() => "Driving...";

    }
}
