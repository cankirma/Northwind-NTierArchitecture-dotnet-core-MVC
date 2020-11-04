using Core.Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Abstract;

namespace DataAccess.Abstract
{
   public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
