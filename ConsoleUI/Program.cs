using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car
            {
                CarId = 3,
                ColorId = 1,
                BrandId = 1,
                DailyPrice = 200,
                Description = "mercedes, otomatik"
            };
            carManager.Add(car);
            foreach (var cars in carManager.GelAll())
            {
                Console.WriteLine(cars.CarId+" "+cars.Description+" "+cars.DailyPrice);
            }
        }
    }
}
