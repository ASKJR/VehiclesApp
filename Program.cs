using VehiclesApp.Model;
using VehiclesApp.Repository;
using VehiclesApp.Data;

namespace VehiclesApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            //var vehicles = new List<Vehicle>
            //{
            //    new Plane(2008, "white", 3),
            //    new Car(2010, "red"),
            //    new Plane(2000, "gray", 2),
            //    new Car(2020, "purple"),
            //};
            //
            var storage = new Storage<Vehicle>();
            var x = storage.LoadData();
            var rep = new Repository<Vehicle>(x);
            var v = rep.GetAll().ToList();
            rep.Insert(new Plane(2000, "BLUE", 110));
            rep.Insert(new Plane(2000, "PINK", 110));
            rep.Insert(new Plane(2000, "PINK", 110));
            v = rep.GetAll().ToList();
            rep.Delete(v[5].Id);
            v = rep.GetAll().ToList();
            var sut = rep.Get(new Guid("81413c78-19aa-49b9-bffc-9c652f65f884"));
            sut.Color = "SHIRO";
            rep.Update(sut);
            storage.WriteData(rep.GetAll());


        }
    }
}