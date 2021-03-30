using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return (List<Car>)_carDal.GetAll();
        }

        public Car GetCarsByCarId(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }

        
        public void Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                //eğer ki iş kodlarından geçerse,
                _carDal.Add(car);//DataAccess katmanına bağlanacağız.
            }
            else
            {
                Console.WriteLine("kaydetme basarisiz, lutfen urun aciklamasini 2 karakterden buyuk ve gunluk masrafi sifirdan buyuk girin");
            }
        }

        

        public void Insert(Car carId)
        {
            _carDal.Add(carId);
        }

        public void Delete(Car carId)
        {
            _carDal.Delete(carId);
        }

        public void Update(Car carId)
        {
            _carDal.Update(carId);
        }

        
    }
}
