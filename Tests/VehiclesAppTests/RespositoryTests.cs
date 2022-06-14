using VehiclesApp.Data;
using VehiclesApp.Model;
using VehiclesApp.Repository;

namespace VehiclesAppTests.Repository
{
    public class RespositoryTests
    {
        private readonly Repository<Vehicle> Repository;

        public RespositoryTests()
        {
            var storage = new Storage<Vehicle>();
            var data = storage.LoadData();
            Repository = new Repository<Vehicle>(data!);
        }

        [Fact(DisplayName = "Insert")]
        public void Should_Insert_A_New_Vehicle_Into_Repository()
        {
            //Arrange
            var plane = new Plane(2009, "Black", 6);
            var vehicles = Repository.GetAll();
            var expectedVehiclesCount = vehicles.Count() + 1;

            //Act
            Repository.Insert(plane);
            vehicles = Repository.GetAll();

            //Assert
            Assert.Equal(expectedVehiclesCount, vehicles.Count());
        }


        [Fact(DisplayName = "Update")]
        public void Should_Update_A_Vehicle()
        {
            //Arrange
            var id = new Guid("e335a290-db4d-412c-abb5-90074d5d65e5");
            var expectedColor = "Blue";
            var plane = new Plane(2009, expectedColor, 6);


            //Act
            Repository.Update(id, plane);
            var updatedPlane = Repository.Get(id);
            var actualColor = updatedPlane.Color;

            //Assert
            Assert.Equal(expectedColor, actualColor);
        }
    }
}