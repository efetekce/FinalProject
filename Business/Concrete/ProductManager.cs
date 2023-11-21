using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(InMemoryProductDal ınMemoryProductDal)
        {
        }

        public List<Product> GetAll()
        {
            // is kodlari - business logic
            return _productDal.GetAll();
        }
    }
}
