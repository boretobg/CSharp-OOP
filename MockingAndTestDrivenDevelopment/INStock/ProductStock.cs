using INStock.Contracts;
using System.Collections.Generic;

namespace INStock
{
    public class ProductStock : IProductStock
    {
        public IProduct this[int index] { get; set; }

        public void Add(IProduct product)
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(IProduct product)
        {
            throw new System.NotImplementedException();
        }

        public int Count()
        {
            throw new System.NotImplementedException();
        }

        public IProduct Find(int nthProduct)
        {
            throw new System.NotImplementedException();
        }

        public List<IProduct> FindAllByPrice(decimal price)
        {
            throw new System.NotImplementedException();
        }

        public List<IProduct> FindAllByQuantity(int quantity)
        {
            throw new System.NotImplementedException();
        }

        public List<IProduct> FindAllInPriceRange(decimal min, decimal max)
        {
            throw new System.NotImplementedException();
        }

        public IProduct FindByLabel(string label)
        {
            throw new System.NotImplementedException();
        }

        public IProduct FindMostExpensiveProducts()
        {
            throw new System.NotImplementedException();
        }

        public List<IProduct> GetEnumerator<Product>()
        {
            throw new System.NotImplementedException();
        }
    }
}
