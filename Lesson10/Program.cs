using Lesson10.Business.Concrete;
using Lesson10.Models;

Manager _productManager = new();


var proByPrice1 = _productManager.GetAllByPrice(23);
foreach (var pro in proByPrice1)
{
    Console.WriteLine(pro.Name+" "+pro.Price);
}
                 