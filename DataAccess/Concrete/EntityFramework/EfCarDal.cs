using Core.DataAccess.EntityFremawork;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepository<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            using (ReCapContext context=new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.ColorId
                             join color in context.Colors
                             on c.ColorId equals color.Id
                             select new CarDetailDto { CarName = c.Description, BrandName = b.BrandName, ColorName = color.ColorName, DailyPrice = c.DailyPrice };

                return result.ToList();
            }
        }
    }
}
