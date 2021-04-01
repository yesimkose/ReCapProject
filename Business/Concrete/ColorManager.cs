using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Delete(Color colorId)
        {
            _colorDal.Delete(colorId);
            return new SuccessResult("Silindi");
        }
        
        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public IResult Insert(Color colorId)
        {
            return new SuccessResult("Eklendi");
        }

        public IResult Update(Color colorId)
        {
            return new SuccessResult("Güncellendi");
        }
    }
}
