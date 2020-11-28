using System.Collections;
using System.Collections.Generic;

namespace INStock.Contracts
{
    public interface IProductStock
    {
        IProduct this[int index] { get; set; }
        void Add(IProduct product);
        bool Contains(IProduct product);
        int Count();
        IProduct Find(int nthProduct);
        IProduct FindByLabel(string label);
        List<IProduct> FindAllInPriceRange(decimal min, decimal max);
        List<IProduct> FindAllByPrice(decimal price);
        IProduct FindMostExpensiveProducts();
        List<IProduct> FindAllByQuantity(int quantity);
        List<IProduct> GetEnumerator<Product>();
    }
}
