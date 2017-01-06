using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Core.Interfaces
{
    public interface IProductRepository
    {
        void Add(Product product);

        void Edit(Product product);

        void Remove(int id);

        List<Product> GetProducts();

        Product FindById(int id);
    }
}
