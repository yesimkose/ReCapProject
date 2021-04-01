using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomersService
    {
        IDataResult<List<Customers>> GetAll();

        IResult Update(Customers customers);
        IResult Delete(Customers customers);
        IResult Add(Customers customers);

        IDataResult<List<Customers>> GetAllById(int Id);
    }
}
