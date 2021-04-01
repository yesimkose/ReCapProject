using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                    new Car {CarId=1,BrandId=1,ColorId=1,DailyPrice=1000,ModelYear="2021",Description="Red BMW M4"},
                  new Car {CarId=2,BrandId=2,ColorId=2,DailyPrice=750,ModelYear="2019",Description="Black Mercedes E250"},
                    new Car {CarId=3,BrandId=3,ColorId=3,DailyPrice=600,ModelYear="2017",Description="White Audi A3"},
                      new Car {CarId=4,BrandId=4,ColorId=4,DailyPrice=350,ModelYear="2015",Description="Blue VW Polo"},
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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public IList<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars.Where(c => c.CarId == c.CarId).ToList();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.BrandId == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailDtos(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
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
