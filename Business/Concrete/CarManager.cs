using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
        public List<Car> GelAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.CarId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
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
    }
}
