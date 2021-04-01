using Business.Abstract;
using Core.Utilities.Result;
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
        public BrandManager(IBrandDal brandDal)
        {
            _brand = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brand.Add(brand);
            return new SuccessResult("eklendi");
        }

        public IResult Delete(Brand brand)
        {
            _brand.Delete(brand);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>((List<Brand>)_brand.GetAll());
        }

        public IDataResult<Brand> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<Brand>(_brand.Get(b => b.BrandId == brandId));
        }

        

        public IResult Update(Brand brand)
        {
            _brand.Update(brand);
            return new SuccessResult("Güncellendi");
        }
    }
}
