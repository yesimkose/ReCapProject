using Business.Abstract;
using Core.Utilities.Result;
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
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), "");

        }

        public IDataResult<Car> GetCarsByCarId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.CarId == id);
        }

        
        public IResult Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                //eğer ki iş kodlarından geçerse,
                _carDal.Add(car);//DataAccess katmanına bağlanacağız.
                return new SuccessResult("eklendi");
            }
            else
            {
                return new ErrorResult("Tekrar deneyin");
            }
        }

        

        public IResult Insert(Car carId)
        {
            _carDal.Add(carId);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(Car carId)
        {
            _carDal.Delete(carId);
            return new SuccessResult("Silindi");
        }

        public IResult Update(Car carId)
        {
            _carDal.Update(carId);
            return new SuccessResult("Eklendi");
        }

        
    }
}
