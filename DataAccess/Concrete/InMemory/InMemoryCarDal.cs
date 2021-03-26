﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
                {
                    new Car{CarId=1,BrandId=1,ColorId=1,ModelYear="2000",DailyPrice=100000,Description="Manuel vites"},
                    new Car{CarId=2,BrandId=7,ColorId=5,ModelYear="2001",DailyPrice=200000,Description="Manuel vites"},
                    new Car{CarId=3,BrandId=8,ColorId=10,ModelYear="2002",DailyPrice=300000,Description="Otomatik vites"},
                    new Car{CarId=4,BrandId=9,ColorId=1,ModelYear="2010",DailyPrice=400000,Description="Otomatik vites"},
                    new Car{CarId=5,BrandId=10,ColorId=2,ModelYear="2005",DailyPrice=50000,Description="Manuel vites"}

                };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.BrandId == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}