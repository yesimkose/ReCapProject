using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFremawork;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepository<Image, ReCapContext>
    {
    }
}
