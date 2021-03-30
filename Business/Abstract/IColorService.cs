using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetByColorId(int colorId);
        void Insert(Color colorId);
        void Delete(Color colorId);
        void Update(Color colorId);

    }
}
