using Lesson10.Business.Abstract;
using Lesson10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.Business.Concrete
{
    public class Manager : IProductService
    {
        List<Product> _products = new() {

             new Product(){ Id = 1, Name = "Dell", Price = 23},
             new Product(){ Id = 2, Name = "Asus", Price = 24},
             new Product(){ Id = 3, Name = "Mackbook", Price = 25},

             };
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByPrice(decimal price)
        {
            var result = _products.Where(x => x.Price > price).ToList();
            return result;
        }
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
