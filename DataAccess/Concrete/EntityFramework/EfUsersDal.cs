using Core.DataAccess.EntityFremawork;
using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUsersDal : EfEntityRepository<User, ReCapContext>
    {
    }
}
