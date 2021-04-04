using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rentals);
        IResult Update(Rental rentals);
        IResult Delete(Rental rentals);
        IDataResult<List<Rental>> GetAll();

        IDataResult<List<Rental>> GetAllById(int Id);
    }
}
