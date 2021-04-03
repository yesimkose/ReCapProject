using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UsersManager:IUsersService
    {
        IUsersDal _userDal;

        public UsersManager(IUsersDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Delete(Users user)
        {
            _userDal.Delete(user);
            return new SuccessResult("Silindi");
        }

        //public IDataResult<List<Users>> GetAll()
        //{
        //    return new SuccessDataResult<List<Users>>(_userDal.GetAll());
        //}

        //public IDataResult<List<Users>> GetAllById(int id)
        //{
        //    return new SuccessDataResult<List<Users>>(_userDal.GetAll(p => p.Id == id));
        //}

        public IResult Add(Users user)
        {
            _userDal.Add(user);
            return new SuccessResult("Eklendi");
        }

        public IResult Update(Users user)
        {
            _userDal.Update(user);
            return new SuccessResult("Güncellendi");
        }

        public IDataResult<List<Users>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Users>> GetAllById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
