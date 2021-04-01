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
            CarTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car {  CarName= "Bmw", BrandId = 7, ColorId = 3, DailyPrice = 1000, Description = "428i Petrol and Automatic", ModelYear = "2021", CarId = 6 });
            Console.WriteLine("Eklendi" + Environment.NewLine);
            list();

            void list()
            {
                Console.WriteLine("Eklendi" + Environment.NewLine);
                foreach (var car in carManager.GetAll().Data)
                {
                    Console.WriteLine(car.CarId + "-- " + car.CarName + "-- " + car.DailyPrice + "$ " + car.Description);
                }
            }
        }

    }
}
