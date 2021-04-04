using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult("Silindi");
        }

        //public IDataResult<List<Rentals>> GetAll()
        //{
        //    return new SuccessDataResult<List<Rentals>>(_rentalDal.GetAll());
        //}

        //public IDataResult<List<Rentals>> GetAllById(int id)
        //{

        //    return new SuccessDataResult<List<Rentals>>(_rentalDal.GetAll(p => p.Id == id));
        //}

        public IResult Add(Rental rental)
        {

            if (rental.ReturnDate == null)
            {

                return new ErrorResult("Eklendi");

            }

            _rentalDal.Add(rental);
            return new SuccessResult("Eklendi");

        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult("Güncellendi");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAllById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
