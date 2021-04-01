using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetCarsByCarId(int id);
        IResult Insert(Car carId);
        IResult Delete(Car carId);
        IResult Update(Car carId);
    }
}
