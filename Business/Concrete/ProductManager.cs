using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal) => _productDal = productDal;

        public void Add(Product entity) => throw new NotImplementedException();

        public void Delete(Product entity) => throw new NotImplementedException();

        public Product Get(Expression<Func<Product, bool>> filter) => throw new NotImplementedException();

        public List<Product> GetAll() => _productDal.GetList();

        public List<Product> GetByCategory(int categoryId) => _productDal.GetList(p => p.CategoryId == categoryId);
        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetList(Expression<Func<Product, bool>> filter = null) => throw new NotImplementedException();

        public void Update(Product entity) => throw new NotImplementedException();
    }
}
