using VehiclesApp.Model;

namespace VehiclesAppTests
{
    public class VehicleTests
    {

        [Fact(DisplayName = "CarMove")]
        public void Should_Validate_Car_Move()
        {
            //Arrange
            var car = new Car(2009, "Black");
            var expectedMove = "Driving...";

            //Act
            var actualMove = car.Move();

            //Assert
            Assert.Equal(expectedMove, actualMove);
        }


        [Fact(DisplayName = "PlaneMove")]
        public void Should_Validate_Plane_Move()
        {
            //Arrange
            var plane = new Plane(2009, "Black", 5);
            var expectedMove = "Flying...";

            //Act
            var actualMove = plane.Move();

            //Assert
            Assert.Equal(expectedMove, actualMove);
        }
    }
}
