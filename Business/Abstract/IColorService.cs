using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult< List<Color>> GetAll();
        IDataResult<Color> GetByColorId(int colorId);
        IResult Insert(Color colorId);
        IResult Delete(Color colorId);
        IResult Update(Color colorId);

    }
}
