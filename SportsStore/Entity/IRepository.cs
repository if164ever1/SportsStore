using SportsStore.Models;
using System.Collections.Generic;

namespace SportsStore.Entity
{
    public interface IRepository
    {
        IEnumerable<Product> Products { get; }
        void AddProduct(Product product);
    }
}
