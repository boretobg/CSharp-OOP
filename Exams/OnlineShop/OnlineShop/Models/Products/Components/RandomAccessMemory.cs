﻿namespace OnlineShop.Models.Products.Components
{
    public class RandomAccessMemory : Component
    {
        private const double multiplier = 1.20;
        protected RandomAccessMemory(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) :
            base(id, manufacturer, model, price, overallPerformance, generation)
        {
        }

        public override double OverallPerformance => base.OverallPerformance * multiplier;
    }
}
