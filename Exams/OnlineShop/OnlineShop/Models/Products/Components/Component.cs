
using IComponent = OnlineShop.Models.Products.Components.IComponent;

namespace OnlineShop.Models.Products
{
    public class Component : Product, IComponent
    {
        protected Component(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) : 
            base(id, manufacturer, model, price, overallPerformance)
        {
            this.Generation = generation;
        }

        public int Generation { get;}

        public override string ToString()
        {
            return base.ToString() + $" Generation: {this.Generation}";
        }
    }
}
