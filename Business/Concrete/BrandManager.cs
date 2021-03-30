using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brand;

        public void Add(Brand brand)
        {
            _brand.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brand.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return (List<Brand>)_brand.GetAll();
        }

        public Brand GetByBrandId(int brandId)
        {
            return _brand.Get(b => b.BrandId == brandId);
        }

        

        public void Update(Brand brand)
        {
            _brand.Update(brand);
        }
    }
}
