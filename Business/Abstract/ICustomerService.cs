using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();

        IResult Update(Customer customers);
        IResult Delete(Customer customers);
        IResult Add(Customer customers);

        IDataResult<List<Customer>> GetAllById(int Id);
    }
}
