using Lesson10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.Business.Abstract
{
    public interface IProductService
    {
        void AddProduct(Product product);
        void Update(int id,Product product);
        List<Product> GetAll();
        List<Product> GetAllByPrice(decimal price);
        Product GetById(int id);

    }
}
