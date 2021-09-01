using DataAccess.Abstract.Repository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISellDal : IEntityRepository<Sell>
    {
    }
}
