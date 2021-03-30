using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetCarsByCarId(int id);
        void Insert(Car carId);
        void Delete(Car carId);
        void Update(Car carId);
    }
}
