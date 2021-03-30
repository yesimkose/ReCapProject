﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetByBrandId(int brandId);

        void Add(Brand brandId);
        void Delete(Brand brandId);
        void Update(Brand brandId);
    }
}
