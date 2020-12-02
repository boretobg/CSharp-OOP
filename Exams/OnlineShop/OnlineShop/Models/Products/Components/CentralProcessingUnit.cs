namespace OnlineShop.Models.Products
{
    public class CentralProcessingUnit : Component
    {
        private const double multiplier = 1.25;

        protected CentralProcessingUnit(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) : 
            base(id, manufacturer, model, price, overallPerformance, generation)
        {
        }

        public override double OverallPerformance => base.OverallPerformance * multiplier;
    }
}
