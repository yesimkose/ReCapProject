using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IList<Color> GetAll(Expression<Func<ThreadStaticAttribute, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
