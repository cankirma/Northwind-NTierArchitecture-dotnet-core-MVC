using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using JetBrains.Annotations;
namespace Business.Abstract
{
   public interface ICategoryService:ICategoryDal
   {
       List<Category> GetAll();
   }
}
