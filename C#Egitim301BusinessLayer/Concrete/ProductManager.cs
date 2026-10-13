using C_Egitim301BusinessLayer.Abstract;
using C_Egitim301EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Egitim301BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        public readonly IProductService _productService;

        public ProductManager(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> GetAll()
        {
            return _productService.GetAll       
        }

        public void TCreate(Product entity)
        {
            _productService.TCreate(entity);
        }

        public void TDelete(Product entity)
        {
            _productService.TDelete(entity);
        }

        public Product TGetById(int id)
        {
            return _productService.TGetById(id);
        }

        public void TUpdate(Product entity)
        {
            _productService.TUpdate(entity);
        }
    }
}
