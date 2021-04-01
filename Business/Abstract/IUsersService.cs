using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUsersService
    {
        IDataResult<List<Users>> GetAll();
        IDataResult<List<Users>> GetAllById(int id);
        IResult Add(Users users);
        IResult Delete(Users users);
        IResult Update(Users users);
    }
}
