﻿using VehiclesApp.Model;
using VehiclesApp.Repository;
using VehiclesApp.Data;

namespace VehiclesApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            var vehicles = new List<Vehicle>
            {
                new Plane(2008, "white", 3),
                new Car(2010, "red"),
                new Plane(2000, "gray", 2),
                new Car(2020, "purple"),
            };
            var storage = new Storage<Vehicle>();
            storage.WriteData(vehicles);
            var x = storage.LoadData();
            var rep = new Repository<Vehicle>(x);
            var v = rep.GetAll();
        }
    }
}