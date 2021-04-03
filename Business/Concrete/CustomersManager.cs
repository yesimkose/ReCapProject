using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomersManager:ICustomersService
    {
        ICustomersDal _customerDal;

        public CustomersManager(ICustomersDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Delete(Customers customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult("Silindi");
        }

        //public IDataResult<List<Customers>> GetAll()
        //{

        //    return new SuccessDataResult<List<Customers>>(_customerDal.GetAll());
        //}

        //public IDataResult<List<Customers>> GetAllById(int id)
        //{
        //    return new SuccessDataResult<List<Customers>>(_customerDal.GetAll(p => p.UserId == id));
        //}

        public IResult Add(Customers customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult("Eklendi");
        }

        public IResult Update(Customers customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult("Güncellendi");
        }

        public IDataResult<List<Customers>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customers>> GetAllById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
