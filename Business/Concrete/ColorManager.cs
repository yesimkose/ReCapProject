using Business.Abstract;
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
        public void Delete(Color colorId)
        {
            _colorDal.Delete(colorId);
        }
        
        public List<Color> GetAll()
        {
            return (List<Color>)_colorDal.GetAll();
        }

        public Color GetByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public void Insert(Color colorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Color colorId)
        {
            throw new NotImplementedException();
        }
    }
}
