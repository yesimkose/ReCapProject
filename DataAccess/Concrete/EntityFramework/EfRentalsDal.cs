using Core.DataAccess.EntityFremawork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalsDal : EfEntityRepository<Rental, ReCapContext>
    {
    }
}
